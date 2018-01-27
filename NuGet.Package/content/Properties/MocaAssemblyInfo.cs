
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Moca.Di.MocaContainerFactory), "Init", Order = 1)]
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Moca.Web.Mvc.MocaControllerFactory), "Init", Order = 2)]
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Moca.Configuration.SectionProtector), "Protect", Order = 3)]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(Moca.Di.MocaContainerFactory), "Destroy")]
