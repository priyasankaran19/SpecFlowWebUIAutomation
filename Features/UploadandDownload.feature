Feature: UploadandDownload

Verify upload and download features
Background: 
	Given The url for the uploadDownload webpage
	And Click Nav item UploadandDownload
@upload
Scenario:Upload feature
	When Click the upload Option
	Then File should get uploaded successfully
@download
Scenario:Download feature
	When Click the download Option
	Then File should get downloaded successfully