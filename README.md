#�ر���Ҫע��,����汾���vs2017  win7ϵͳ  �ؼӼ�ס 
1.��װvs2017 רҵ��� Ҫ��װ https://www.microsoft.com/en-us/download/details.aspx?id=40855  power shell 4.0
2.��unget �����ԴҪ���һ������� https://dotnet.myget.org/F/aspnetcore-dev/api/v3/index.json

3.�ڻ������� path ��һ��Ҫ����vs2017  
����ֵΪ"C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\IDE\devenv.exe"
�� ϵͳ���������� C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\Tools

4.������ݿ�Ϊ2005 ��2008 ��Ҫ�޸��ļ�
   EntityFrameworkCore��Ŀ�е� MyABPDbContextConfigurer�ļ����¼���
 public static class MyABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyABPDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            //֧��sql2005,2008�ķ�ҳ
            builder.UseSqlServer(connectionString, b => b.UseRowNumberForPaging());

        }

        public static void Configure(DbContextOptionsBuilder<MyABPDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            //֧��sql2005,2008�ķ�ҳ

            builder.UseSqlServer(connection, b => b.UseRowNumberForPaging());
        }
    }
����

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