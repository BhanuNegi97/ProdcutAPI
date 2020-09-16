﻿ use ProductDB
 go
 DECLARE @json NVARCHAR(MAX);
SET @json = N'
  [
  {
    "name": "Security & Antivirus",
    "imagee": "https://lh4.ggpht.com/j79ht2KSJ0O5pydTlCOwNzsnTnSu1tSjO5ahEgROrvcogHE2WZt8sJD9mzG-SA0GRFE=w300-rw",
    "type": "Productivity",
    "price": "1.2",
    "rating": "4.3",
    "users": "272599",
    "last_update": "April 13, 2015",
    "description": "McAfee Mobile Security & Antivirus protects and enhances your Android phone or tablet’s performance with award winning Antitheft, Find Device, App Privacy Protection, Antivirus, Battery Optimizer (Extend Battery & Memory Cleanup), and Security features from Intel Security. ",
    "url": "https://play.google.com/store/apps/details?id=com.wsandroid.suite"
  },
  {
    "name": "Security Innovations",
    "imagee": "https://lh4.ggpht.com/GZAaxEGaEMwP5gaWk-QRumvvWAi6qiGlQZJIP74D7QkVWTShmsuNuvq32LaqlVzajzE=w300-rw",
    "type": "Tools",
    "price": "0",
    "rating": "4.2",
    "users": "15318",
    "last_update": "April 01, 2015",
    "description": "Mobile Innovations provides you with an opportunity to try out groundbreaking new features and to give us feedback on how to improve them…or ditch them altogether. The list of features will grow and evolve over time based on your feedback.",
    "url": "https://play.google.com/store/apps/details?id=com.mcafee.mmi"
  },
  {
    "name": "Battery Optimizer丨Save Battery",
    "imagee": "https://lh4.ggpht.com/zbF6xZUq7GOtx9aJ2VJtxY_sQxR_7s7CbrorcPYewGCgcCTkGBSYT16ajfA0zwk_9gM=w300-rw",
    "type": "Productivity",
    "price": "3.2",
    "rating": "4.4",
    "users": "425",
    "last_update": "April 9, 2015",
    "description": "Intel Security Battery Optimizer is an All-in-one battery energy boosting and power management tool for Android smartphone and tablets. Saves battery life, provides real-time power usage information, alerts you when battery is low or time to charge battery, extends call time, and helps you deal with various battery wasting situations with ease.",
    "url": "https://play.google.com/store/apps/details?id=com.mcafee.batteryoptimizer"
  },
  {
    "name": "McAfee EMM",
    "imagee": "https://lh6.ggpht.com/GV9OaHTi8oiH-DJBDrqoA7D3D3LVgPABuKEUiZtTX2hTKN2qFu_JiAbM3D2TP7uWBzU=w300-rw",
    "type": "Productivity",
    "price": "1.3",
    "rating": "4.0",
    "users": "1431",
    "last_update": "May 1, 2014",
    "description":"The McAfee Enterprise Mobility Management (EMM) solution simplifies connecting a user Android device to existing enterprise IT services such as email, VPN and Wi-Fi access.",
    "url": "https://play.google.com/store/apps/details?id=com.mcafee.apps.emmagent"
  },
  {
    "name": "Secure Container",
    "imagee": "https://lh6.ggpht.com/OjdyPeEuB5qiR29yxsX9lkxvkwxA8TmrhK5M8OMxRYLBiMSl7ykYOd2KrgGhQvLNWz4=w300-rw",
    "type": "Productivity",
    "price": "0",
    "rating": "4.1",
    "users": "819",
    "last_update": "July 3, 2014",
    "description": "Using a FIPS-certified encryption library, McAfee Secure Container for Android keeps company data secure and provides protection for email, contacts, and calendar - where ever you and your mobile device go.",
    "url": "https://play.google.com/store/apps/details?id=com.mcafee.apps.easmail"
  },
  {
    "name": "Heartbleed Detector",
    "imagee": "https://lh3.ggpht.com/yUPMZUPu2h1o8oFE349WS0Ucq4KNfFaMDMks6tBRlt2VlTEuXWYLJ7xj26pxZnUdD44=w300-rw",
    "type": "Tools",
    "price": "0",
    "rating": "4.2",
    "users": "922",
    "last_update": "April 23, 2014",
    "description": "This app determines if your device or any apps installed on your device are affected by the Heartbleed bug.",
    "url": "https://play.google.com/store/apps/details?id=com.mcafee.heartbleed"
  },
  {
    "name": "Pledge",
    "imagee": "https://lh6.ggpht.com/cYxTl3GkqcS7q1lKOcBy-js_J-1uHgpIxg8FXzyy3Uq1Wuktf6FivoBq5ThfaPLQ14_l=w300-rw",
    "type": "Tools",
    "price": "4.5",
    "rating": "4.1",
    "users": "293",
    "last_update": "April 23, 2014",
    "description": "Pledge is a software token that makes your device an easy to use and cost-effective authentication token. With Pledge you can generate one-time password without Internet connection enabling you to authenticate to protected corporate remote access services, virtual desktop environments, bring your own device services, web applications, and cloud services.",
    "url": "https://play.google.com/store/apps/details?id=se.nordicedge.pledgeotp"
  },
  {
    "name": "True Key",
    "imagee": "https://lh4.ggpht.com/vu3f04LfsQKUy1pUC2WkRzInEqzEml4pyHLrJEsyrzdhOUcuAAF-JRZ7A6Dg5gBm8Bs=w300-rw",
    "type": "Productivity",
    "price": "0",
    "rating": "3.2",
    "users": "35",
    "last_update": "March 5, 2015",
    "description": "Access your digital world without the hassle of having to remember, create or manage multiple passwords. With True Key by Intel Security, you are the password. Unlock your apps and websites using your facial features.",
    "url": "https://play.google.com/store/apps/details?id=com.truekey.android"
  },
  {
    "name": "Family Protection",
    "imagee": "https://lh3.ggpht.com/HepSwsHYxwqVK4TDOJOI6OtPn07SMwld4qvir-w1rtoxevr1EqwUa9gHGuMmhCPQvzYP=w300-rw",
    "type": "Tools",
    "price": "1.2",
    "rating": "3.1",
    "users": "1006",
    "last_update": "January 8, 2015",
    "description": "Family Protection provides parental control and filters websites by categories such as blocking websites that are categorized as, ‘gambling’, ‘sex’ and many others. It protects your kids from viewing inappropriate content so you can be worry-free knowing that your kids mobile lifestyle is now protected.",
    "url": "https://play.google.com/store/apps/details?id=com.mcafee.android.familyprotection"
  },
  {
    "name": "File Protect | Secure vault",
    "imagee": "https://lh3.googleusercontent.com/IsKTTY0PEiQoUiQL-8AZcI0edP36jRWnOh-dTDms3cSIJEu6jNqZ7xoVyCXbmh2djg=w300-rw",
    "type": "Productivity",
    "price": "0",
    "rating": "5.0",
    "users": "50",
    "last_update": "April 15, 2015",
    "description": "Have personal photos, videos or docs you’d like to keep to yourself? Take full control of your privacy–protect your most sensitive content from prying eyes. File Protect encrypts your data and hides it behind a secure PIN, making it virtually unreadable to anyone but you. ",
    "url": "https://play.google.com/store/apps/details?id=com.intelsecurity.fileprotect"
  },
  {
    "name": "McAfee VPN Client",
    "imagee": "https://lh5.ggpht.com/93BVR9TCBp5lIo0ohbVtSdUmiofO5Yn3Evrrws1_f1IAXGsi70ZjKU7Ag9fEugRtiuk=w300-rw",
    "type": "Business",
    "price": "1.5",
    "rating": "4.1",
    "users": "36",
    "last_update": "December 11, 2014",
    "description": "McAfee® VPN Client provides a secure remote connection to your company network. Strong encryption prevents eavesdropping and modification of the traffic. McAfee VPN Client enables easy and secure remote access to private networks where McAfee® Next Generation Firewall is used as a VPN gateway.",
    "url": "https://play.google.com/store/apps/details?id=com.mcafee.sslvpn"
  },
  {
    "name": "Fake ID Detector",
    "imagee": "https://lh3.ggpht.com/iugqqNy_CIyqE_H2uiH84tg2i6F0-wPyHd5aOg2CUBbZgYhLbzSwLtzZwOhf_vvl8HE=w300-rw",
    "type": "Business",
    "price": "0",
    "rating": "4.2",
    "users": "270",
    "last_update": "August 21, 2014",
    "description": "Fake ID is an Android vulnerability that allows applications to impersonate other applications by copying their identity that can then be used for malicious purposes.",
    "url": "https://play.google.com/store/apps/details?id=com.mcafee.stinger.fakeid"
  },
  {
    "name": "Personal Locker",
    "imagee": "https://lh4.ggpht.com/1qQDSQbvqZfJVGWZxPcp-mo3snjU-Y9SzRb-cB0poaaliVyhlKFf6wPjdI0spo7fnA=w300-rw",
    "type": "Productivity",
    "price": "0",
    "rating": "4.8",
    "users": "611",
    "last_update": "March 27, 2014",
    "description": "Secure sensitive documents using face verification with McAfee Personal Locker. NOTE: This product is only for users who have already downloaded and purchased McAfee LiveSafe service. If you’re interested, please visit home.mcafee.com/LiveSafe.",
    "url": "https://play.google.com/store/apps/details?id=com.mcafee.personallocker"
  },
  {
    "name": "McAfee SafeKey",
    "imagee": "https://lh4.ggpht.com/FO1IaeFh8qg8YI2y_cCejJ941xqq0wDJErVsodtbtWFKUwC5aA-pvcGxmY3zNfaD3V8=w300-rw",
    "type": "Productivity",
    "price": "1.2",
    "rating": "4.0",
    "users": "1128",
    "last_update": "September 26, 2013",
    "description": "Never forget your passwords again with McAfee SafeKey password manager.",
    "url": "https://play.google.com/store/apps/details?id=com.mcafee.safekey"
  },
  {
    "name": "Selfie App",
    "imagee": "https://lh6.ggpht.com/VGjfK9i5Yno-_zPICeVa-UzbRX7r7ZKuYh_Y4IMZFscKSqz47JF3zrOco02fkFjUcQ=w300-rw",
    "type": "Personalization",
    "price": "0",
    "rating": "3.9",
    "users": "78",
    "last_update": "August 3, 2014",
    "description": "Say cheese! Smile. Snap a photo. Add “Andy” the Android*. Share on the Intel® Developer Zone Facebook page and through Twitter using the #IntelAndroid hashtag. The Intel Selfie App is a simple and fun native-built Android* app that offers a chance to pose with Andy and see yourself on screen at big events in the Intel® Software booth.",
    "url": "https://play.google.com/store/apps/details?id=com.intel.selfie"
  },
  {
    "name": "Intel Free Press",
    "imagee": "https://lh5.ggpht.com/UxT9-J-3vlurwxsQSJWLfdDeflb4NJdyBAcUeBGfVAMHh__ul4ZSTOuHJCrxwQ3DZOM=w300-rw",
    "type": "News & Magazines",
    "price": "0.5",
    "rating": "4.0",
    "users": "22",
    "last_update": "January 23, 2014",
    "description": "Free Press is a tech news site from Intel Corporation, covering technology and innovation stories that are often overlooked or warrant more context and deeper reporting.",
    "url": "https://play.google.com/store/apps/details?id=com.doapps.android.mln.MLN_b85b9817cc7f74e4690e239c65960ee3"
  }
]';


insert into Product
SELECT *  
FROM OPENJSON(@json)  
  WITH (
    [name] varchar(max), 
    [imagee] varchar(max), 
    [type] nvarchar(max), 
    [price] float, 
    [rating] float, 
    [users] nvarchar(max), 
	[last_update] datetime2,
	[description] nvarchar(max), 
    [url] nvarchar(max) 
  )



