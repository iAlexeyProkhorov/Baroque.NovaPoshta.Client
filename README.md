# Baroque.NovaPoshta.Client

Hi everyone! Today I want to present you a 'Nova Poshta' API client. 'Nova Poshta' it's Ukrainian most popular delivery service. It has strong web API,
which needed sometimes for Ukrainian developers.

A few steps to start working with client:
* Create your personal 'Nova Poshta' account and generate your Api key. Detailed instruction you can find [here](https://developers.novaposhta.ua/documentation).
* You need to create class implementing interface **INovaPoshtaGateway**. Or you can use our default class **DefaultNovaPoshtaGateway**. 
Copy your API key created at first step and paste it in ApiKey parameter or your gateway instance like here:
```C#
using Baroque.NovaPoshta.Client;
var gateway = new DefaultNovaPoshtaGateway("yourkey");
```
* Great! You create instance of Nova Poshta gateway. Now you can use API services, which are located in namespace _Baroque.NovaPoshta.Client.Services_. For example you can try get **CommonService**.


```C#
using Baroque.NovaPoshta.Client.Services.Common;
void Run()
{
    var gateway = new DefaultNovaPoshtaGateway("yourkey");
    var commonService = new CommonService(gateway);
}
```
* All other services connect by same way.
* Now you can use all other services in your application.

From version 1.3.0 library also supports documents tracking. 
You can find tracking service in Baroque.NovaPoshta.Client.Services.Tracking namespace.

Thanks to [Dmitry](https://github.com/Demonchik) for pointing out what I missed.

Nuget: ```Install-Package Baroque.NovaPoshta.Client -Version 1.4.4```

### Feel free to write me about project bugs and issues.

