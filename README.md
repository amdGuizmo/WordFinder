# WordFinder

How to setup the solution:

1. Clon the project
2. Open it on VS2022 .Net 8.0
3. Install Microsoft Visual Studio Installer Projects 2022
4. Restore NuGet Packages

Folders description:

-Artifacts: All the documents that describe the project
-Pack: All the release artifacts like setup and Dlls
-WordFinder: WindowsForms project for view layer
-WordFinderLib: ClassLibrary project with the logic
-WordFinderSetup: Setup project
-WordFinderTest: Test project with all the tests for WordFinderLib

How to generate a new setup

1. Select Release configuration
2. Go to WordFinderSetup project
3. Right clic over the project 
4. Select build or rebuild
5. Go to .\WordFinderSetup\Release
6. Copy setup.exe and WordFinderSetup.msi to Pack folder
7. Generate MD5

How to run test from WordFinderTest

1. Go to Test menu on VS2022
2. Select Run All Tests option