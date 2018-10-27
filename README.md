#特别需要注意,多个版本后的vs2017  win7系统  特加记住 
1.安装vs2017 专业版后 要安装 https://www.microsoft.com/en-us/download/details.aspx?id=40855  power shell 4.0
2.在unget 程序包源要添加一个程序包 https://dotnet.myget.org/F/aspnetcore-dev/api/v3/index.json

3.在环境变量 path 中一定要增加vs2017  
变量值为"C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\IDE\devenv.exe"
在 系统变量中增加 C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\Tools

4.如果数据库为2005 或2008 需要修改文件
   EntityFrameworkCore项目中的 MyABPDbContextConfigurer文件如下即可
 public static class MyABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyABPDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            //支持sql2005,2008的分页
            builder.UseSqlServer(connectionString, b => b.UseRowNumberForPaging());

        }

        public static void Configure(DbContextOptionsBuilder<MyABPDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            //支持sql2005,2008的分页

            builder.UseSqlServer(connection, b => b.UseRowNumberForPaging());
        }
    }
　　

# Introduction


This is a template to create **ASP.NET Core MVC / Angular** based startup projects for [ASP.NET Boilerplate](https://aspnetboilerplate.com/Pages/Documents). It has 2 different versions:

1. [ASP.NET Core MVC & jQuery](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core) (server rendered multi-page application).
2. [ASP.NET Core & Angular](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular) (single page application).
 
User Interface is based on [BSB Admin theme](https://github.com/gurayyarar/AdminBSBMaterialDesign).
 
# Download

Create & download your project from https://aspnetboilerplate.com/Templates

# Screenshots

#### Sample Dashboard Page
![](_screenshots/module-zero-core-template-ui-home.png)

#### User Creation Modal
![](_screenshots/module-zero-core-template-ui-user-create-modal.png)

#### Login Page

![](_screenshots/module-zero-core-template-ui-login.png)

# Documentation

* [ASP.NET Core MVC & jQuery version.](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core)
* [ASP.NET Core & Angular  version.](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular)

# License

[MIT](LICENSE).