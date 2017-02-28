# LBPL
这一个基于Asp.net、 quartz.net 快速开发定时服务的插件化项目

  由于在实际项目开发中需要做定时服务的操作，大体上可以理解为：需要动态化监控定时任务的调度系统。
  
  为了实现快速开发、简单明了完成一个服务，不再繁琐的进行各种代码耦合度强的操作，设计了一个以暂时以quartz.net 为服务载体，插件化开发的模式。
  
  
  主要开发流程
  
 1、 开发人员 新建类库 类库名称格式 LBPL.PlugIn.{xxxxx}ServicePlugin
  
 2、引用LBPL.PlugIn.Integration、LBPL.PlugIn.Model 两个类库
 
 3、实例化三个类分别继承：ICronConfig、IJobLibray、IJobsConfig 三个接口
 
 3.1 CronConfig 这个类用于配置时间表达式 （目前配置在主项目的AppSetting中，后期会单独抽离）

 3.2 JobLibray 服务资源池  用友动态加载 本服务插件类库中 定时任务

 3.3  JobsConfig 具体Quartz.net 定时服务调度
 
 4、完成以上操作，自动编译生dll，通过自定义操作（简单的选择dll） 调用 仓储方法
 
  AddQuartzServer(IJobDetail jobDetail, Quartz.Collection.HashSet<ITrigger> triggerList, out string error, bool IsRun = true)
  
  就可以实现一个简单服务的自动调用了
  
  5、监控各种服务状态
  
  调用该方法，可以获取所有服务状态
  
   List<JobsTrigger> GetALLQuartzServer(); 
   
  
