# LBPL
This is a plug-in project based on Asp.net, quartz.net for rapid development of timed services

  As in the actual project development need to do regular service operation, in general can be understood as: the need to dynamically monitor the timing task scheduling system.
  
  In order to achieve rapid development, simple and clear to complete a service, no longer cumbersome for a variety of code coupling strong operation, designed a temporary to quartz.net service carrier, plug-in development model.
  
  
  The main development process
  
 1、the developer of the new library class library name format LBPL.PlugIn. {Xxxxx} ServicePlugin

 2、 cited LBPL.PlugIn.Integration, LBPL.PlugIn.Model two class libraries
 
 3、 the implementation of the three categories were inherited: ICronConfig, IJobLibray, IJobsConfig three interfaces
 
 3.1 CronConfig This class is used to configure the time expression (currently configured in the main project of AppSetting, the latter will be a separate pull away)

 3.2 The JobLibray service resource pool is used to dynamically load the scheduled tasks in the service plug-in class library

 3.3 JobsConfig specific Quartz.net timing service scheduling configuration
 
 4、 to complete the above operations, automatic translation dll, through the custom operation (simple choice dll) call the storage method
 
  AddQuartzServer (IJobDetail jobDetail, Quartz.Collection.HashSet <ITrigger> triggerList, out string error, bool IsRun = true)
  
  You can achieve a simple service of the automatic call
  
 5、monitoring a variety of service status
  
  Call the method to get all the service status
  
   List <JobsTrigger> GetALLQuartzServer ();
  
