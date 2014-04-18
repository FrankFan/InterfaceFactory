### A Practice Project for understanding Factory Design Pattern.

#### Desc

* 接口类库：IDAL
* 实现类库：OracleDAL和SQLServerDAL
* 工厂类库：DALFactory
* UI：Web

#### Notice

- 类库之间调用时要先添加引用
- 工厂类中通过调用web.config中字符串动态加载创建类（反射）
- 理解接口和工厂的概念，体会好处
