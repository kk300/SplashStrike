<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - "Splash Strike! - プロボウラーチャレンジスケジュールまとめサイト - "</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <script data-ad-client="ca-pub-1068622611384585" async src="https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js">
    </script>
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Splash Strike!", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("ホーム", "Index", "Home")</li>
                    <li>@Html.ActionLink("ボウリング場", "About", "Home")</li>
                    <!-- <li>@Html.ActionLink("問い合わせ", "Contact", "Home")</li> -->
                </ul>
            </div>
        </div>
    </div>


    <div class="jumbotron">
        <h1>Splash Strike</h1>
        <p class="lead">プロボウラーチャレンジスケジュールまとめサイト</p>
    </div>


    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - KK300 Projects</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
