@echo off
@setlocal enableDelayedExpansion & rem Important for being able to use variables correctly in a loop

for %%i in (%*) do (
	:: Must be updated to the current game version
	set "version=1.3.1"
	if not exist "%~dp0table" (
		mkdir "%~dp0Table"
		@echo Generated Table folder.
	)
	if "%%~xi" == ".tbl" ( :: Similar to an if statement, checks to see if there are any existing files in the Table folder
		dir /b /s /a "%~dp0table" | findstr .>nul && (
  			choice /m "Do you want to clear the Table folder first?"
			if !errorlevel! == 1 (
				del /q "%~dp0table\*.tbl"
				@echo Cleared Table folder.
			)
		)
		if exist "%~dp0table\%%~nxi" (
			choice /m "Do you want to back up the existing file \"%%~nxi\"?"
			if !errorlevel! == 1 ( :: Following code moves and renames the file so it isn't overwritten, adding numbers if other backups exist
				if exist "%~dp0%%~ni_backup.tbl" (
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
		:: Copies input file to table folder
		copy /y "%%~i" "%~dp0table"
		if exist "%~dp0db.sqlite" (
			choice /m "Do you want to clear the existing \"db.sqlite\" database?"
			if !errorlevel! == 1 (
				del /q "%~dp0db.sqlite"
				@echo Cleared existing "db.sqlite" database.
			)
		)
		:: Always outputs to db.sqlite
		"%~dp0GBFRDataTools.exe" tbl-to-sqlite -i "%~dp0table" -o "%~dp0db.sqlite" -v !version!
		@echo Converted and inserted into "db.sqlite". && pause && exit
	) else if "%%~xi" == ".sqlite" ( :: Always just outputs to Table folder, nothing fancy
		"%~dp0GBFRDataTools.exe" sqlite-to-tbl -i %%i -o "%~dp0table" -v !version!
		@echo Check Table folder for output. && pause && exit
	) else if exist "%%~i\*.tbl" ( :: If input is a folder that contains .tbl files
		if exist "%~dp0db.sqlite" (
			choice /m "Do you want to clear the existing \"db.sqlite\" database?"
			if !errorlevel! == 1 (
				del /q "%~dp0db.sqlite"
				@echo Cleared existing "db.sqlite" database.
			)
		)
		:: Always outputs to db.sqlite
		"%~dp0GBFRDataTools.exe" tbl-to-sqlite -i "%%~i" -o "%~dp0db.sqlite" -v !version!
		@echo Converted and inserted into "db.sqlite". && pause && exit
	) else (
		@echo Can^'t convert %%~xi files, please only use .tbl or .sqlite files, or folders containing .tbl files. && pause && exit
	)
)

@exit
