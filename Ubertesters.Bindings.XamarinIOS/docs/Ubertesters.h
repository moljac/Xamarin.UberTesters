//
//  Ubertesters.h
//  Ubertesters
//
//  Created by Ubertesters on 9/7/13.
//  Copyright (c) 2014 Ubertesters. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@class CustomViewUberTesters;
@class UserProfileViewController;
@class LockScreenViewControllerUberTesters;

/*!
 * @typedef Ubertesters different mode options.
 * @brief A list of option for Ubertesters launch.
 * @code [[Ubertesters shared] 
    initializeWithOptions:UTOptionsSlider];
 */
typedef enum {
    /*!Default options (Slider and UTOptionsLockingModeDisableUbertestersIfBuildNotExist).*/
    UbertestersOptionsDefault = 0,
    
    /*!Option for using Slider mode.*/
    UbertestersOptionsSlider = 1 << 0,
    
    /*!Option for using Shake mode.*/
    UbertestersOptionsShake = 1 << 1,
    
    /*!Option for Manual mode.*/
    UbertestersOptionsManual = 1 << 2,
    
    /*!Option for Locking mode (default).*/
    UbertestersOptionsLockingModeDisableUbertestersIfBuildNotExist = 1 << 3,

    /*!Option for Locking mode.*/
    UbertestersOptionsLockingModeAppIfBuildNotExist = 1 << 4
    
} UbertestersOptions;

typedef enum  {
    LockingModeDisableUbertestersIfBuildNotExist = 0,
    LockingModeLockAppIfBuildNotExist = 1,
} LockingMode;

/*!
 * @typedef UTLog options.
 * @brief Three option for UTLog method.
 * @code [[Ubertesters shared] UTLog:@"Some text..."
                withLevel:UTLogLevelInfo];
 */
typedef enum
{
    /*!Error level*/
    UTLogLevelError,
    /*!Warning level*/
    UTLogLevelWarning,
    /*!Information level*/
    UTLogLevelInfo
} UTLogLevel;

@interface Ubertesters : NSObject <UITextViewDelegate>

@property (nonatomic, readonly) LockScreenViewControllerUberTesters *lockScreen;
@property (nonatomic, readonly) UserProfileViewController *userProfileScreen;
@property (nonatomic, retain) NSString* apiKey;
@property (nonatomic, retain) CustomViewUberTesters *mainView;

@property (nonatomic, assign) BOOL isOpenGL;
@property (nonatomic, assign) BOOL isInit;
@property (nonatomic, assign) BOOL isHide;
@property (nonatomic, assign) BOOL autoUpdate;

/*!
 *if there is no internet connection user can work in offline mode
 */
@property (nonatomic) BOOL offlineMode;

@property (nonatomic) BOOL isError;

/*!
 * if customer sends this property in dictionary properties as YES -> after app receive error code APPLICATION NO FOUND -> we will not close the app
 
 Default is LockingModeDisableUbertestersIfBuildNotExist
 */
@property (nonatomic, assign)LockingMode lockingMode;

/*!
 *  Main method for accessing Ubertesters singleton.
 *
 *  @return Ubertestrs singleton.
 */
+ (Ubertesters*) shared;

/*!
 Initialize Ubertesters framework with default properties:
 LockingMode = LockingModeDisableUbertestersIfBuildNotExist,
 ActivationMode = UTSlider
 @warning You should initialize Ubertesters after you initialize your view controlllers, just before return YES!
 */
- (void)initialize;

/*!
 This method is deprecated!
 @see initializeWithOptions:
 */
- (void)initialize:(LockingMode)mode __attribute__((deprecated(" use 'initializeWithOptions:' instead.")));

/*!
 Initialize Ubertesters framework with user`s options:
 UTOptionsSlider initialize Ubertesters with menu picker buttons.
 UTOptionsShake initialize Ubertesters with shake gesture.
 UTOptionsManual initialize Ubertesters with manual mode.
 @warning You should initialize Ubertesters after you initialize your view controlllers, just before return YES!
 */
- (void)initializeWithOptions:(UbertestersOptions)options;

//API
/*!
 *  Makes Screenshot of any view (openGL or UIKit).
 */
- (void)makeScreenshot;
/*!
 *  Shows menu slider.
 */
- (void)showMenuSlider;
/*!
 *  Hides menu slider.
 */
- (void)hideMenuSlider;
/*!
 *  Shows Ubertesters menu.
 */
- (void)showMenu;
/*!
 *  Hides Ubertesters menu.
 */
- (void)hideMenu;
/*!
 This method is deprecated!
 @see UTLog:withLevel:
 */
- (void)UTLog:(NSString *)format level:(NSString *)level __attribute__((deprecated(" use 'UTLog:withLevel:' instead.")));
/*!
 *  Logs custom message into session.
 *
 *  @param format of type NSString
 *  @param level of type UTLogLevel
 */
- (void)UTLog:(NSString *)format withLevel:(UTLogLevel)level;

// public functions for lib's classes
- (BOOL)isOnline;
- (NSString *)getPhoneState;
- (void)makeAppExit;
- (void)showLockScreen;
- (void)postLogs:(NSString*)logs token:(NSString *)token;
- (void)postCrash:(NSString*)log token:(NSString *)token state:(NSString *)state rid: (NSString *)rid uid: (NSString *)uid;
- (void)makeUTLibWindowKeyAndVisible;
- (UIWindow *)getUTLibWindow;
- (void)playSystemSound:(int)soundID;
- (void)enableTimer:(BOOL)res;

@end

/*!Handle Exception*/
void HandleUbertestersException(NSException *exception);
/*!Calls when signal occures in the system*/
void SignalUbertestersHandler(int signal);
/*!Install Urban HandleEception to the app and uber menu*/
void installUberErrorHandler(void);

