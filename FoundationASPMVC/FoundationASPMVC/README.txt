/****** Installation Instructions ******

1. Update the Layout

Open the /Views/_ViewStart.cshtml
Change the Layout to _Foundation.cshtml like the example below:

@{
    //This is the default MVC template
    //Layout = "~/Views/Shared/_Layout.cshtml";
    
    //This is the Foundation MVC template
    Layout = "~/Views/Shared/_Foundation.cshtml";
}

2. Remove the default theme

Once the ViewStart has been updated. Replace the default Index.cshtml.

Rename ~/Views/Home/Index.cshtml to Index.cshtml.exclude (or delete the file)
Rename ~/Views/Home/Foundation_Index.cshtml to Index.cshtml
Rename ~/Content/Site.css to Site.css.exclude (or delete the file)

3. Automatic Bundling and Minification

Bundling and minification is automatically set up for you. The App_Start folder a contains
pre-configured bundling and minification bootstrapper.

4.

You are now ready to begin building your MVC project using Foundation.

/****** Related Nuget packages ******
Want to rapid prototype and wire frame directly from code using Html Helpers? 
Try the prototyping package on nuget. It works great with Foundation.
http://www.nuget.org/packages/Prototyping_MVC

Having trouble with media queries? Debug them with this simple CSS file.
http://nuget.org/packages/CSS_Media_Query_Debugger

/****** Documentation ******
Docs http://foundation.zurb.com/docs/
A Crashcourse in Responsive Design http://www.slideshare.net/edcharbeneauii/a-crash-course-in-responsive-design-12007229

Follow us:
Ed Charbeneau http://twitter.com/#!/edcharbeneau
Foundation Zurb http://twitter.com/#!/foundationzurb


/****** Package Information ******
Files added during install:

~/App_Start
~/App_Start/BundleConfig.cs

~/Content/core
~/Content/core/foundation.css

~/Content/app.css
~/Content/ie.css

~/Content/images/themes/foundation/orbit
~/Content/images/themes/foundation/orbit/bullets.jpg
~/Content/images/themes/foundation/orbit/left-arrow.png
~/Content/images/themes/foundation/orbit/loading.gif
~/Content/images/themes/foundation/orbit/mask-black.png
~/Content/images/themes/foundation/orbit/pause-black.png
~/Content/images/themes/foundation/orbit/right-arrow.png
~/Content/images/themes/foundation/orbit/rotator-black.png
~/Content/images/themes/foundation/orbit/timer-black.png

~/Scripts/app.js

~/Scripts/core
~/Scripts/core/
~/Scripts/core/jquery.foundation.reveal.js
~/Scripts/core/jquery.foundation.orbit.js
~/Scripts/core/jquery.foundation.navigation.js
~/Scripts/core/jquery.foundation.buttons.js
~/Scripts/core/jquery.foundation.tabs.js
~/Scripts/core/jquery.foundation.forms.js
~/Scripts/core/jquery.foundation.tooltips.js
~/Scripts/core/jquery.foundation.accordion.js
~/Scripts/core/jquery.placeholder.js
~/Scripts/core/jquery.foundation.alerts.js

~/humans.txt
~/robots.txt
~/MIT-LICENSE.txt
~/README.txt (this file)

~/Views/Home/Foundation_Index.cshtml

~/Views/Shared/_Foundation.cshtml

Dependencies:
Microsoft.Web.Optimization
WebActivator
jQuery

Change Log:

Version 0.0.307
Test release

Note: version scheme <major>.<minor>.<foundation version>
foundation version represents the foundation version less the "." for example 2.1.4 would be #.#.214

Foundation Framework Support:
http://foundation.zurb.com/docs/support.php