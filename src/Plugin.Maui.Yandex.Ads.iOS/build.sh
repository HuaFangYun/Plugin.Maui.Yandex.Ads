SDK=$(sharpie xcode -sdks | awk '/sdk: iphoneos.*/{print $2}' | head -n 1)
if [ -z "$SDK" ]; then
    echo "No SDK found"
    exit 1
fi

echo "SDK used: ${SDK}"
sharpie bind -framework ./Frameworks/YandexMobileAds.framework -sdk "${SDK}" -namespace Plugin.Maui.Yandex.Ads.iOS