/*
 *  YMANativeContentAd.h
 *
 * This file is a part of the Yandex Advertising Network.
 *
 * Version for iOS © 2017 YANDEX
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at https://legal.yandex.com/partner_ch/
 */

#import <Foundation/Foundation.h>
#import <YandexMobileAds/YMANativeGenericAd.h>

@class YMANativeContentAdView;
@protocol YMANativeAdDelegate;

NS_ASSUME_NONNULL_BEGIN

/**
 * YMANativeContentAd allows to bind content ad to view. 
 * @see YMANativeGenericAd.h for generic ad methods.
 */
@protocol YMANativeContentAd <YMANativeGenericAd>

/**
 * Sets values of all content ad assets to native content ad view, installs impression and click handlers.
 *
 * @param view Root ad view, superview for all asset views.
 * @param delegate Ad delegate, which provides view controller for presenting modal content and handles ad events.
 * Passed delegate overwrites ad @p delegate property value. 
 * @param error Binding error. @see YMANativeAdErrors.h for error codes.
 *
 * @return YES if binding succeeded, otherwise NO.
 */
- (BOOL)bindContentAdToView:(YMANativeContentAdView *)view
                   delegate:(nullable id<YMANativeAdDelegate>)delegate
                      error:(NSError **)error;

@end

NS_ASSUME_NONNULL_END
