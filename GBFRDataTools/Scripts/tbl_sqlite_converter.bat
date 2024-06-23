@echo off
setlocal enableDelayedExpansion :: Important for being able to use variables correctly in a loop

for %%i in (%*) do (
	set "version=1.3.1"	&& :: Must be updated to the current game version
	if not exist "%~dp0table" (
		mkdir "%~dp0Table"
		@echo Generated Table folder.
	)
	if "%%~xi" == ".tbl" (
		dir /b /s /a "%~dp0table" | findstr .>nul && ( :: Similar to an if statement, checks to see if there are any existing files in the Table folder
  			choice /m "Do you want to clear the Table folder first?"
			if !errorlevel! == 1 (
				del /q "%~dp0table\*.tbl"
				@echo Cleared Table folder.
			)
		)
		if exist "%~dp0table\%%~nxi" (
			choice /m "Do you want to back up the existing file \"%%~nxi\"?"
			if !errorlevel! == 1 (
				if exist "%~dp0%%~ni_backup.tbl" ( :: Following code moves and renames the file so it isn't overwritten, adding numbers if other backups exist
					set /a "cnt=1"
					for /r "%~dp0" %%j in ("%%~ni_backup*.tbl") do (
						if "%%~nj" == "%%~ni_backup!cnt!" (
							set /a cnt+=1
						)
					)
					move /y "%~dp0table\%%~nxi" "%~dp0%%~ni_backup!cnt!.tbl"
					@echo Backed up existing "%%~nxi" to "%%~ni_backup!cnt!.tbl"
				) else (
					move /y "%~dp0table\%%~nxi" "%~dp0%%~ni_backup.tbl"
					@echo Backed up existing "%%~nxi" to "%%~ni_backup.tbl"
				)
			) else ( :: If you choose to not back up the existing file it will be overwritten
				@echo Overwriting existing "%%~nxi".
			)
		)
		copy /y "%%~i" "%~dp0table" :: Copies input file to table folder
		set /a "cnt=0"
		for /r "%~dp0table" %%j in ("*.tbl") do set /a cnt+=1
		if !cnt! gtr 1 ( :: If there are multiple files in the Table folder output to db.sqlite
			if exist "%~dp0db.sqlite" (
				choice /m "Do you want to clear the existing \"db.sqlite\" database?"
				if !errorlevel! == 1 (
					del /q "%~dp0db.sqlite"
					@echo Cleared existing "db.sqlite" database.
				)
			)
			"%~dp0GBFRDataTools.exe" tbl-to-sqlite -i "%~dp0table" -v !version!
			@echo Converted and inserted into "db.sqlite". && pause && exit
		) else ( :: If only 1 file in Table folder output to <name>.sqlite
			"%~dp0GBFRDataTools.exe" tbl-to-sqlite -i "%~dp0table" -o "%~dp0%%~ni.sqlite" -v !version!
			@echo Converted to "%%~ni.sqlite". && pause && exit
		)
	) else if "%%~xi" == ".sqlite" (
		set /a "cnt=0"
		if not exist "%~dp0table\%%~ni.tbl" ( :: If <name>.tbl isn't already in Table folder assume at least one new file will be created
			for /r "%~dp0table" %%j in ("*.tbl") do set /a cnt+=1
			set /a cnt+=1
		) else (
			for /r "%~dp0table" %%j in ("*.tbl") do set /a cnt+=1
		)
		"%~dp0GBFRDataTools.exe" sqlite-to-tbl -i %%i -o "%~dp0table" -v !version!
		set /a "cntAfter=0"
		for /r "%~dp0table" %%j in ("*.tbl") do set /a cntAfter+=1
		if !cntAfter! == !cnt! ( :: Compares file count before and after conversion to see if multiple new files were created
			if exist "%~dp0table\%%~ni.tbl" ( :: Then if there weren't multiple new files created check if there is a <name>.tbl created
				if exist "%~dp0%%~ni.tbl" ( :: If <name>.tbl was created check to make sure it won't overwrite an existing <name>.tbl
					choice /m "Do you want to backup the existing file \"%%~ni.tbl\"?"
					if !errorlevel! == 1 (
						if exist "%~dp0%%~ni_backup.tbl" (
							set /a "cnt=1"
							for /r "%~dp0" %%j in ("%%~ni_backup*.tbl") do (
								if "%%~nj" == "%%~ni_backup!cnt!" (
									set /a cnt+=1
								)
							)
							ren "%~dp0%%~ni.tbl" "%~dp0%%~ni_backup!cnt!.tbl"
							@echo Backed up existing "%%~nxi" to "%%~ni_backup!cnt!.tbl"
						) else (
							ren %~dp0%%~ni.tbl" "%~dp0%%~ni_backup.tbl"
							@echo Backed up existing "%%~nxi" to "%%~ni_backup.tbl"
						)
					) else (
						@echo Overwriting existing "%%~nxi".
					)
				)
				move /y "%~dp0table\%%~ni.tbl" "%~dp0%%~ni.tbl" && :: Move <name>.tbl to the parent directory so you don't have to go into the Table folder
				@echo Converted to "%%~ni.tbl". && pause && exit
			)
		)
		@echo Check the Table folder for output. && pause && exit :: Either multiple new files were created, or no output files matched the name of <name>.sqlite
	) else if exist "%%~i\*.tbl" ( :: If input is a folder that contains .tbl files
		set /a "cnt=0"
		for %%j in ("%%~i\*.tbl") do set /a cnt+=1
		if !cnt! gtr 1 ( :: Checks if more than one .tbl in the input folder, and if so outputs to db.sqlite
			if exist "%~dp0db.sqlite" (
				choice /m "Do you want to clear the existing \"db.sqlite\" database?"
				if !errorlevel! == 1 (
					del /q "%~dp0db.sqlite"
					@echo Cleared existing "db.sqlite" database.
				)
			)
			"%~dp0GBFRDataTools.exe" tbl-to-sqlite -i "%%~i" -v !version!
			@echo Converted and inserted into "db.sqlite". && pause && exit
		) else ( :: If only one file, grab the file's name and output to <name>.sqlite
			for %%j in ("%%~i\*.tbl") do set "file=%%~nj"
			"%~dp0GBFRDataTools.exe" tbl-to-sqlite -i "%%~i" -o "%~dp0!file!.sqlite" -v !version!
			@echo Converted "!file!.tbl" to "!file!.sqlite". && pause && exit
		)
	) else (
		@echo Can^'t convert %%~xi files, please only use .tbl or .sqlite files, or folders containing .tbl files. && pause && exit
	)
)

@exit
