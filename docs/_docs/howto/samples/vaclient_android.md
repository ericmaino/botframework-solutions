---
category: How To
subcategory: Samples
title: Use the Virtual Assistant Client (Android)
description: Steps for using the Virtual Assistant Client on Android
order: 1
---

# {{ page.title }}
{:.no_toc}

## In this how-to
{:.no_toc}

* 
{:toc}

## Prerequisites

1. Install [Android Studio](https://developer.android.com/studio/) on your PC.

1. [Create a Virtual Assistant]({{ site.baseurl }}/tutorials/csharp/create-assistant/1_intro/) to setup your Virtual Assistant environment.

1. [Enable speech]({{ site.baseurl }}/tutorials/enable-speech/1_intro) on your new Virtual Assistant, which enables you to retrieve a
    - [Microsoft Speech Cognitive Service subscription key]({{ site.baseurl }}/tutorials/enable-speech/2_create_speech_instance/)
    - [Add the Direct Line Speech channel to your Assistant]({{ site.baseurl }}/tutorials/enable-speech/3_add_speech_channel/)
    
1. [Download](https://aka.ms/virtualassistantclient) the Virtual Assistant Client (Android) app source code.

## Overview
![Virtual Assistant Client (Android) overview diagram]({{ site.baseurl }}/assets/images/virtualassistantclient-android-overview.png)

A user can interact with their Assistant using the **Virtual Assistant Client app** via widgets on the home screen or the main UI of the app. 
These bot responses can optionally be broadcast to an **Event Companion app** that does't need to implement the Speech SDK.

## Building the project

### Provide credentials to the application

The following configuration values must be supplied to `DefaultConfiguration.java` to connect to the Assistant via the Direct Line Speech channel:
* `SPEECH_SERVICE_SUBSCRIPTION_KEY`
* `DIRECT_LINE_SPEECH_SECRET_KEY`
* `USER_FROM_ID`

```java
public class DefaultConfiguration {

    // Replace below with your own subscription key
    public static final String SPEECH_SERVICE_SUBSCRIPTION_KEY = "YOUR_KEY_HERE";//TODO

    public static final String DIRECT_LINE_SPEECH_SECRET_KEY = "YOUR_DIRECTLINE_SPEECH_KEY_HERE";//TODO

    public static final String SPEECH_SERVICE_SUBSCRIPTION_KEY_REGION = "westus2";//TODO

    public static final String USER_NAME = "User";
    public static final String USER_FROM_ID = "YOUR_USER_FROM_ID_HERE";//TODO

    public static final String LOCALE = "en-us";

    public static final String KEYWORD = "computer";

    // please note that the default colors are read from /res/values/colors.xml
}
```
**Note:** that there are two versions, one for debug and one for release build flavors.

The USER_FROM_ID is a unique identifier for all messages generated by the user, this is typically combined with [Linked Accounts]({{ site.baseurl }}/howto/virtual-assistant/linkedaccounts/).

### Deploy
1. Select the desired build flavor (debug or release) and ensure credentials are set for the desired build flavor
2. Deploy to emulator or device

## Using the Project
### Permissions
 - **Record Audio**
    - Required for the user to make voice requests to a bot. With this a user can only use the keyboard.
 - **Fine Location**
     - Allow your Assistant to receive the `VA.Location` event with GPS coordinates to utilize location-based skills like Point of Interest.

## Interacting with your Assistant
### Conversation view
![Conversation view]({{ site.baseurl }}/assets/images/virtualassistantclient-android-fullconversationview.png)

To demonstrate a chat app experience with an Assistant, the main screen shows user/bot interactions with a threaded conversation.
Trigger a conversation by selecting either:
* Mic button to speak to the bot
* Keyboard button to type to the bot

### Native view
![Native view]({{ site.baseurl }}/assets/images/virtualassistantclient-android-widgetview.png)

Using widgets, you can demonstrate an Assistant having a native chat experience on a device.

### Menu
Swipe from the left to access the menu, providing the following functionality:
* Restart conversation
* Settings

## Features

Learn more about the [Virtual Assistant Client (Android) comprehensive feature set]({{ site.baseurl }}/reference/samples/vaclient_android/)
