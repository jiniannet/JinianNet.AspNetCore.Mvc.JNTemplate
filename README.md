# ����JntemplateViewEngine
JntemplateViewEngine�ǻ���Jntemplate��ASP.NET MVC��ͼ���棬����˵������������ASP.NET MVC�и������ʹ��Jntemplate.

JntemplateԴ����Դ�����ĵ�ַ��ȡ

GITEE�����ڣ���https://gitee.com/jiniannet/jntemplate
GITHUB��https://github.com/jiniannet/jntemplate

Jntemplate �ĵ���http://docs.jiniannet.com/

# ��������
- ģ��ʹ���º�׺.jnt ���� .html

## ������ͼ����
- �� `Startup.cs`����ConfigureServices����������`AddJntemplateViewEngine`,������ʾ
```
        public void ConfigureServices(IServiceCollection services)
        {
            //...��������
            //Add Jntemplate ViewEngine
            services.AddJntemplateViewEngine();
        }

```

- ��`Configure`����������`UseJntemplate`,������ʾ
```
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //...��������
            //Use Jntemplate
            app.UseJntemplate(jntemplateConfig =>
            {
                //��������Ҳ���Խ�����������������
                jntemplateConfig.ContentRootPath = env.ContentRootPath;
            });
        }

```

## ������ͼ
��Views\Home������һ��Index.html ����Index.jnt �������£�
```html
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>${Site.Name}</title> 
</head>
<body>
    <h1>Welcome to ${Site.Name}!</h1>
    <p>Engine Version:${Site.Version} &copy;${Now.Year}</p>
</body>
</html>
```

## ����Action
��HomeController������һ��Index��Action
```
        public IActionResult Index()
        {
            this.Set("Site", new SiteViewModel
            {
                Name = "Jntemplate",
                Version = JinianNet.JNTemplate.Engine.Version
            });
            this.Set("Now", DateTime.Now);
            return View();
        }
```
����ɲο���ʾ��ĿJntemplateViewEngineDemo
 
 