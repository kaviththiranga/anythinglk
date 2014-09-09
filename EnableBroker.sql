ALTER DATABASE anythinglk SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

ALTER DATABASE anythinglk SET ENABLE_BROKER;

ALTER DATABASE anythinglk SET MULTI_USER;

SELECT is_broker_enabled FROM sys.databases WHERE name ='anythinglk';

aspnet_regsql.exe -S kavithdelln5010\sqlexpress -U sa -P 123456 -d anythinglk -ed