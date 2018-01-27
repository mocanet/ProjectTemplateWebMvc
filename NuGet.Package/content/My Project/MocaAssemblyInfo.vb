
<Assembly: WebActivatorEx.PreApplicationStartMethod(GetType(Moca.Di.MocaContainerFactory), "Init", Order:=1)>
<Assembly: WebActivatorEx.PreApplicationStartMethod(GetType(Moca.Web.Mvc.MocaControllerFactory), "Init", Order:=2)>
<Assembly: WebActivatorEx.PreApplicationStartMethod(GetType(Moca.Configuration.SectionProtector), "Protect", Order:=3)>
<Assembly: WebActivatorEx.ApplicationShutdownMethod(GetType(Moca.Di.MocaContainerFactory), "Destroy")>
