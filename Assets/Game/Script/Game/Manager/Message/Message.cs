namespace Game.Manager.Message
{
	public enum Message
	{
		/// <summary>
		/// 猫薄荷田
		/// </summary>
		BUILDINGS_FIELD_LABEL,
		/// <summary>
		/// 在村庄种植一些猫薄荷。猫薄荷田的产量在春天 +50%，冬天 -75%
		/// </summary>
		BUILDINGS_FIELD_DESC,
		/// <summary>
		/// 一望无际的猫薄荷
		/// </summary>
		BUILDINGS_FIELD_FLAVOR,
		/// <summary>
		/// 牧场
		/// </summary>
		BUILDINGS_PASTURE_LABEL,
		/// <summary>
		/// 提供了新的食物来源，猫薄荷的需求减少了
		/// </summary>
		BUILDINGS_PASTURE_DESC,
		/// <summary>
		/// 来一杯牛奶，先生!
		/// </summary>
		BUILDINGS_PASTURE_FLAVOR,
		/// <summary>
		/// 太阳能发电站
		/// </summary>
		BUILDINGS_SOLARFARM_LABEL,
		/// <summary>
		/// 提供了会受季节影响的新能源
		/// </summary>
		BUILDINGS_SOLARFARM_DESC,
		/// <summary>
		/// 水渠
		/// </summary>
		BUILDINGS_AQUEDUCT_LABEL,
		/// <summary>
		/// 猫薄荷产量 +3%
		/// </summary>
		BUILDINGS_AQUEDUCT_DESC,
		/// <summary>
		/// 禁止游泳!
		/// </summary>
		BUILDINGS_AQUEDUCT_FLAVOR,
		/// <summary>
		/// 水电站
		/// </summary>
		BUILDINGS_HYDROPLANT_LABEL,
		/// <summary>
		/// 现代化的能源
		/// </summary>
		BUILDINGS_HYDROPLANT_DESC,
		/// <summary>
		/// 小屋
		/// </summary>
		BUILDINGS_HUT_LABEL,
		/// <summary>
		/// 建造一间小屋(每间可容纳 2 只小猫)。小猫需要吃猫薄荷，不然就会饿死。\n每只小猫每秒需要约 4 猫薄荷
		/// </summary>
		BUILDINGS_HUT_DESC,
		/// <summary>
		/// 二之国
		/// </summary>
		BUILDINGS_HUT_FLAVOR,
		/// <summary>
		/// 木屋
		/// </summary>
		BUILDINGS_LOGHOUSE_LABEL,
		/// <summary>
		/// 建造一间木屋(每间可容纳 1 只小猫)
		/// </summary>
		BUILDINGS_LOGHOUSE_DESC,
		/// <summary>
		/// 原木搭建的小房子
		/// </summary>
		BUILDINGS_LOGHOUSE_FLAVOR,
		/// <summary>
		/// 宅邸
		/// </summary>
		BUILDINGS_MANSION_LABEL,
		/// <summary>
		/// 一间宽敞的宅邸(每间可容纳 1 只小猫)
		/// </summary>
		BUILDINGS_MANSION_DESC,
		/// <summary>
		/// 最高品级的纸箱!
		/// </summary>
		BUILDINGS_MANSION_FLAVOR,
		/// <summary>
		/// 图书馆
		/// </summary>
		BUILDINGS_LIBRARY_LABEL,
		/// <summary>
		/// 建立一个图书馆来储存猫类的宝贵知识。每一级使科学产出增加 10%
		/// </summary>
		BUILDINGS_LIBRARY_DESC,
		/// <summary>
		/// 全都写满了喵喵
		/// </summary>
		BUILDINGS_LIBRARY_FLAVOR,
		/// <summary>
		/// 研究院
		/// </summary>
		BUILDINGS_ACADEMY_LABEL,
		/// <summary>
		/// 增加研究效率和小猫工作技能的成长速率。每一级使科学产出增加 20%
		/// </summary>
		BUILDINGS_ACADEMY_DESC,
		/// <summary>
		/// 好奇心乃是科学之基石。吾等猫类死得高贵
		/// </summary>
		BUILDINGS_ACADEMY_FLAVOR,
		/// <summary>
		/// 天文台
		/// </summary>
		BUILDINGS_OBSERVATORY_LABEL,
		/// <summary>
		/// 发生天文事件的概率增加 0.2%
		/// </summary>
		BUILDINGS_OBSERVATORY_DESC,
		/// <summary>
		/// 渴望能有一天找到闪耀红光的精灵
		/// </summary>
		BUILDINGS_OBSERVATORY_FLAVOR,
		/// <summary>
		/// 生物实验室
		/// </summary>
		BUILDINGS_BIOLAB_LABEL,
		/// <summary>
		/// 猫薄荷精炼产率增加 10%，通电后效能提升
		/// </summary>
		BUILDINGS_BIOLAB_DESC,
		/// <summary>
		/// 现已开放全新的博士后职位
		/// </summary>
		BUILDINGS_BIOLAB_FLAVOR,
		/// <summary>
		/// 粮仓
		/// </summary>
		BUILDINGS_BARN_LABEL,
		/// <summary>
		/// 提供了储存资源的空间
		/// </summary>
		BUILDINGS_BARN_DESC,
		/// <summary>
		/// 对我们而言老鼠可算不上问题!
		/// </summary>
		BUILDINGS_BARN_FLAVOR,
		/// <summary>
		/// 仓库
		/// </summary>
		BUILDINGS_WAREHOUSE_LABEL,
		/// <summary>
		/// 提供了储存资源的空间
		/// </summary>
		BUILDINGS_WAREHOUSE_DESC,
		/// <summary>
		/// 所有存货上都有爪印
		/// </summary>
		BUILDINGS_WAREHOUSE_FLAVOR,
		/// <summary>
		/// 港口
		/// </summary>
		BUILDINGS_HARBOR_LABEL,
		/// <summary>
		/// 提供了储存资源的空间
		/// </summary>
		BUILDINGS_HARBOR_DESC,
		/// <summary>
		/// 嘿，旱喵子们!
		/// </summary>
		BUILDINGS_HARBOR_FLAVOR,
		/// <summary>
		/// 矿井
		/// </summary>
		BUILDINGS_MINE_LABEL,
		/// <summary>
		/// 解锁矿工职业。每一级使矿物产出增加 20%
		/// </summary>
		BUILDINGS_MINE_DESC,
		/// <summary>
		/// 安全挖矿一百天
		/// </summary>
		BUILDINGS_MINE_FLAVOR,
		/// <summary>
		/// 采石场
		/// </summary>
		BUILDINGS_QUARRY_LABEL,
		/// <summary>
		/// 每一级使采矿效率增加 35%，同时产出少量的煤
		/// </summary>
		BUILDINGS_QUARRY_DESC,
		/// <summary>
		/// 到处都是老鼠!等等，目标不是它们!
		/// </summary>
		BUILDINGS_QUARRY_FLAVOR,
		/// <summary>
		/// 熔炉
		/// </summary>
		BUILDINGS_SMELTER_LABEL,
		/// <summary>
		/// 将矿石冶炼成金属
		/// </summary>
		BUILDINGS_SMELTER_DESC,
		/// <summary>
		/// 小心你的胡须!
		/// </summary>
		BUILDINGS_SMELTER_FLAVOR,
		/// <summary>
		/// 煅烧炉
		/// </summary>
		BUILDINGS_CALCINER_LABEL,
		/// <summary>
		/// 高效的金属来源。每一跳消耗 1.5 矿石和 0.02 石油。产出铁和少量的钛
		/// </summary>
		BUILDINGS_CALCINER_DESC,
		/// <summary>
		/// 蒸汽工房
		/// </summary>
		BUILDINGS_STEAMWORKS_LABEL,
		/// <summary>
		/// 启动后显著降低煤产量。一开始什么也做不了，经过升级就能做很多很酷的事情
		/// </summary>
		BUILDINGS_STEAMWORKS_DESC,
		/// <summary>
		/// 我只是在这儿打盹，但就好像我在工作一样
		/// </summary>
		BUILDINGS_STEAMWORKS_FLAVOR,
		/// <summary>
		/// 磁电机
		/// </summary>
		BUILDINGS_MAGNETO_LABEL,
		/// <summary>
		/// 全部资源产出提升 2%，每一级蒸汽工房都将使此效能增幅 15%，消耗石油
		/// </summary>
		BUILDINGS_MAGNETO_DESC,
		/// <summary>
		/// 木材厂
		/// </summary>
		BUILDINGS_LUMBERMILL_LABEL,
		/// <summary>
		/// 木材产出增加 10%
		/// </summary>
		BUILDINGS_LUMBERMILL_DESC,
		/// <summary>
		/// 木材解体、日志分析的最佳良伴
		/// </summary>
		BUILDINGS_LUMBERMILL_FLAVOR,
		/// <summary>
		/// 油井
		/// </summary>
		BUILDINGS_OILWELL_LABEL,
		/// <summary>
		/// 产出少量的石油，石油存储上限 +1500
		/// </summary>
		BUILDINGS_OILWELL_DESC,
		/// <summary>
		/// 早起，苦干，采油。
		/// </summary>
		BUILDINGS_OILWELL_FLAVOR,
		/// <summary>
		/// 工坊
		/// </summary>
		BUILDINGS_WORKSHOP_LABEL,
		/// <summary>
		/// 提供大量的可升级项。工艺制作效率提升 6%
		/// </summary>
		BUILDINGS_WORKSHOP_DESC,
		/// <summary>
		/// 猫玩具供员工免费使用
		/// </summary>
		BUILDINGS_WORKSHOP_FLAVOR,
		/// <summary>
		/// 工厂
		/// </summary>
		BUILDINGS_FACTORY_LABEL,
		/// <summary>
		/// 提升工艺制作效率
		/// </summary>
		BUILDINGS_FACTORY_DESC,
		/// <summary>
		/// 反应堆
		/// </summary>
		BUILDINGS_REACTOR_LABEL,
		/// <summary>
		/// 启动后提供 5% 的生产加成。运作需要铀
		/// </summary>
		BUILDINGS_REACTOR_DESC,
		/// <summary>
		/// 发光的老鼠捉起来容易得多!
		/// </summary>
		BUILDINGS_REACTOR_FLAVOR,
		/// <summary>
		/// 加速器
		/// </summary>
		BUILDINGS_ACCELERATOR_LABEL,
		/// <summary>
		/// 将钛转变为铀(原文如此)
		/// </summary>
		BUILDINGS_ACCELERATOR_DESC,
		/// <summary>
		/// 大型喵子对撞机
		/// </summary>
		BUILDINGS_ACCELERATOR_FLAVOR,
		/// <summary>
		/// 交易所
		/// </summary>
		BUILDINGS_TRADEPOST_LABEL,
		/// <summary>
		/// 猫族贸易帝国的心脏。交易效率提升 1.5%，稀有资源消耗量减少 4%
		/// </summary>
		BUILDINGS_TRADEPOST_DESC,
		/// <summary>
		/// 我希望他们能讲讲旅途中的奇闻趣事
		/// </summary>
		BUILDINGS_TRADEPOST_FLAVOR,
		/// <summary>
		/// 铸币厂
		/// </summary>
		BUILDINGS_MINT_LABEL,
		/// <summary>
		/// 以喵力上限的一定比例产出奢侈品。消耗喵力和少量黄金
		/// </summary>
		BUILDINGS_MINT_DESC,
		/// <summary>
		/// 剧场
		/// </summary>
		BUILDINGS_AMPHITHEATRE_LABEL,
		/// <summary>
		/// 猫口过剩的负面影响减轻 5%，这一效果可以叠加但增益递减。产出文化
		/// </summary>
		BUILDINGS_AMPHITHEATRE_DESC,
		/// <summary>
		/// 广播塔
		/// </summary>
		BUILDINGS_BROADCASTTOWER_LABEL,
		/// <summary>
		/// 产出文化与幸福。能源过剩时效能提升
		/// </summary>
		BUILDINGS_BROADCASTTOWER_DESC,
		/// <summary>
		/// 教堂
		/// </summary>
		BUILDINGS_CHAPEL_LABEL,
		/// <summary>
		/// 产出少量的文化与信仰。也许能被宗教的升级提升
		/// </summary>
		BUILDINGS_CHAPEL_DESC,
		/// <summary>
		/// 神殿
		/// </summary>
		BUILDINGS_TEMPLE_LABEL,
		/// <summary>
		/// 光之神殿\n产出文化。也许能被神学提升
		/// </summary>
		BUILDINGS_TEMPLE_DESC,
		/// <summary>
		/// 赞美薮猫!
		/// </summary>
		BUILDINGS_TEMPLE_FLAVOR,
		/// <summary>
		/// 独角兽牧场
		/// </summary>
		BUILDINGS_UNICORNPASTURE_LABEL,
		/// <summary>
		/// 驯养独角兽。猫薄荷消耗减少 0.15% 
		/// </summary>
		BUILDINGS_UNICORNPASTURE_DESC,
		/// <summary>
		/// 我们在马头上粘了一只角!
		/// </summary>
		BUILDINGS_UNICORNPASTURE_FLAVOR,
		/// <summary>
		/// 庙塔
		/// </summary>
		BUILDINGS_ZIGGURAT_LABEL,
		/// <summary>
		/// 失落种族的黑暗遗迹，每级庙塔使文化上限提升 8%\n在研究神学后可能有其他用途
		/// </summary>
		BUILDINGS_ZIGGURAT_DESC,
		/// <summary>
		/// 超时空传送仪
		/// </summary>
		BUILDINGS_CHRONOSPHERE_LABEL,
		/// <summary>
		/// 使少量资源能够穿越时间。可以进一步升级。每级超时空传送仪都将增加时间悖论的发生概率
		/// </summary>
		BUILDINGS_CHRONOSPHERE_DESC,
		/// <summary>
		/// 确定升级这个建筑吗?\n\n你将失去当前已经建成的建筑。
		/// </summary>
		BUILDINGS_UPGRADE_CONFIRMATION_MSG,
		/// <summary>
		/// 确定降级这个建筑吗?\n\n你将失去当前已经建成的建筑。
		/// </summary>
		BUILDINGS_DOWNGRADE_CONFIRMATION_MSG,
		/// <summary>
		/// 采集猫薄荷
		/// </summary>
		BUILDINGS_GATHERCATNIP_LABEL,
		/// <summary>
		/// 在森林中采些猫薄荷
		/// </summary>
		BUILDINGS_GATHERCATNIP_DESC,
		/// <summary>
		/// 精炼猫薄荷
		/// </summary>
		BUILDINGS_REFINECATNIP_LABEL,
		/// <summary>
		/// 将猫薄荷精炼成猫薄荷木
		/// </summary>
		BUILDINGS_REFINECATNIP_DESC,
		/// <summary>
		/// 营火
		/// </summary>
		BUILDINGS_TABNAME,
		/// <summary>
		/// 食物生产
		/// </summary>
		BUILDINGS_GROUP_FOOD,
		/// <summary>
		/// 猫口
		/// </summary>
		BUILDINGS_GROUP_POPULATION,
		/// <summary>
		/// 科学
		/// </summary>
		BUILDINGS_GROUP_SCIENCE,
		/// <summary>
		/// 储藏
		/// </summary>
		BUILDINGS_GROUP_STORAGE,
		/// <summary>
		/// 资源
		/// </summary>
		BUILDINGS_GROUP_RESOURCE,
		/// <summary>
		/// 工业
		/// </summary>
		BUILDINGS_GROUP_INDUSTRY,
		/// <summary>
		/// 文化
		/// </summary>
		BUILDINGS_GROUP_CULTURE,
		/// <summary>
		/// 其他
		/// </summary>
		BUILDINGS_GROUP_OTHER,
		/// <summary>
		/// 超级建筑
		/// </summary>
		BUILDINGS_GROUP_MEGASTRUCTURES,
		/// <summary>
		/// 伐木工
		/// </summary>
		VILLAGE_JOB_WOODCUTTER,
		/// <summary>
		/// 木材每秒 +0.09
		/// </summary>
		VILLAGE_JOB_WOODCUTTER_DESC,
		/// <summary>
		/// 农民
		/// </summary>
		VILLAGE_JOB_FARMER,
		/// <summary>
		/// 猫薄荷每秒 +5
		/// </summary>
		VILLAGE_JOB_FARMER_DESC,
		/// <summary>
		/// 学者
		/// </summary>
		VILLAGE_JOB_SCHOLAR,
		/// <summary>
		/// 科学每秒 +0.175
		/// </summary>
		VILLAGE_JOB_SCHOLAR_DESC,
		/// <summary>
		/// 猎人
		/// </summary>
		VILLAGE_JOB_HUNTER,
		/// <summary>
		/// 喵力每秒 +0.3
		/// </summary>
		VILLAGE_JOB_HUNTER_DESC,
		/// <summary>
		/// 矿工
		/// </summary>
		VILLAGE_JOB_MINER,
		/// <summary>
		/// 矿物每秒 +0.25
		/// </summary>
		VILLAGE_JOB_MINER_DESC,
		/// <summary>
		/// 牧师
		/// </summary>
		VILLAGE_JOB_PRIEST,
		/// <summary>
		/// 信仰每秒 +0.0075
		/// </summary>
		VILLAGE_JOB_PRIEST_DESC,
		/// <summary>
		/// 地质学家
		/// </summary>
		VILLAGE_JOB_GEOLOGIST,
		/// <summary>
		/// 煤每秒 +0.075 (可升级)
		/// </summary>
		VILLAGE_JOB_GEOLOGIST_DESC,
		/// <summary>
		/// 工程师
		/// </summary>
		VILLAGE_JOB_ENGINEER,
		/// <summary>
		/// 工程师能够操作工厂进行资源自动化生产\n在工坊页面指派工程师，他们每 10 分钟将自动制作一次
		/// </summary>
		VILLAGE_JOB_ENGINEER_DESC,
		/// <summary>
		/// 只小猫
		/// </summary>
		VILLAGE_MSG_KITTEN,
		/// <summary>
		/// 只小猫
		/// </summary>
		VILLAGE_MSG_KITTENS,
		/// <summary>
		/// 饿死了
		/// </summary>
		VILLAGE_MSG_STARVED,
		/// <summary>
		/// 冻死了
		/// </summary>
		VILLAGE_MSG_FROZE,
		/// <summary>
		/// 你的猎人回来了
		/// </summary>
		VILLAGE_MSG_HUNT_SUCCESS,
		/// <summary>
		///  从 {0} 次狩猎中
		/// </summary>
		VILLAGE_MSG_HUNT_FROM,
		/// <summary>
		/// +{0} 毛皮
		/// </summary>
		VILLAGE_MSG_HUNT_FURS,
		/// <summary>
		/// +{0} 象牙
		/// </summary>
		VILLAGE_MSG_HUNT_IVORY,
		/// <summary>
		/// +{0} 黄金
		/// </summary>
		VILLAGE_MSG_HUNT_GOLD,
		/// <summary>
		/// 所有工作
		/// </summary>
		VILLAGE_CENSUS_FILTER_ALL,
		/// <summary>
		/// 工艺制作增益
		/// </summary>
		VILLAGE_BONUS_DESC_ENGINEER,
		/// <summary>
		/// 贸易增益
		/// </summary>
		VILLAGE_BONUS_DESC_MERCHANT,
		/// <summary>
		/// 狩猎增益
		/// </summary>
		VILLAGE_BONUS_DESC_MANAGER,
		/// <summary>
		/// 科学价格奖励
		/// </summary>
		VILLAGE_BONUS_DESC_SCIENTIST,
		/// <summary>
		/// 宗教奖励
		/// </summary>
		VILLAGE_BONUS_DESC_WISE,
		/// <summary>
		/// 文化节已加钟,
		/// </summary>
		VILLAGE_FESTIVAL_MSG_EXT,
		/// <summary>
		/// 文化节已经开始了
		/// </summary>
		VILLAGE_FESTIVAL_MSG_START,
		/// <summary>
		/// 小猫们的工作已经根据他们的技能重新分配。
		/// </summary>
		VILLAGE_REASSIGN_MSG,
		/// <summary>
		/// 成为上院议员
		/// </summary>
		VILLAGE_BTN_SENATOR,
		/// <summary>
		/// 解除领袖
		/// </summary>
		VILLAGE_BTN_UNASSIGN,
		/// <summary>
		/// 取消分配
		/// </summary>
		VILLAGE_BTN_UNASSIGN_JOB,
		/// <summary>
		/// 职业加成
		/// </summary>
		VILLAGE_JOB_BONUS,
		/// <summary>
		/// 领袖
		/// </summary>
		VILLAGE_CENSUS_LBL_LEADER,
		/// <summary>
		/// 举办节日
		/// </summary>
		VILLAGE_BTN_FESTIVAL,
		/// <summary>
		/// 举办一个文化节来令喵星人们开心一下。(接下来的一年时间幸福度 +30%，成长速率加倍)
		/// </summary>
		VILLAGE_BTN_FESTIVAL_DESC,
		/// <summary>
		/// 派出猎人
		/// </summary>
		VILLAGE_BTN_HUNTERS,
		/// <summary>
		/// 派出猎人到森林
		/// </summary>
		VILLAGE_BTN_HUNTERS_DESC,
		/// <summary>
		/// 管理职业
		/// </summary>
		VILLAGE_BTN_MANAGE,
		/// <summary>
		/// 领袖根据小猫的工作经验优化职业分配
		/// </summary>
		VILLAGE_BTN_MANAGE_DESC,
		/// <summary>
		/// 提拔小猫
		/// </summary>
		VILLAGE_BTN_PROMOTE,
		/// <summary>
		/// 领袖提拔小猫，需要黄金来庆祝
		/// </summary>
		VILLAGE_BTN_PROMOTE_DESC,
		/// <summary>
		/// 打开礼物盒
		/// </summary>
		VILLAGE_BTN_UNWRAP,
		/// <summary>
		/// 猫口普查
		/// </summary>
		VILLAGE_PANEL_CENSUS,
		/// <summary>
		/// 管理
		/// </summary>
		VILLAGE_PANEL_MANAGEMENT,
		/// <summary>
		/// 幸福度影响工人的生产效率和猫薄荷消耗量\n稀有资源使幸福度增加，而过剩的猫口使之减少
		/// </summary>
		VILLAGE_PANEL_MANAGEMENT_DESC,
		/// <summary>
		/// 节日持续时间
		/// </summary>
		VILLAGE_CENSUS_LBL_FESTIVAL_DURATION,
		/// <summary>
		/// 幸福
		/// </summary>
		VILLAGE_CENSUS_LBL_HAPPINESS,
		/// <summary>
		/// 无特质 :< 
		/// </summary>
		VILLAGE_CENSUS_TRAIT_NONE,
		/// <summary>
		/// 等级
		/// </summary>
		VILLAGE_CENSUS_RANK,
		/// <summary>
		/// 提拔 ({0} 经验, {1} 黄金)
		/// </summary>
		VILLAGE_CENSUS_LEADER_PROPMOTE,
		/// <summary>
		/// 清除
		/// </summary>
		VILLAGE_BTN_JOB_CLEAR,
		/// <summary>
		/// 清除所有分配的工作
		/// </summary>
		VILLAGE_BTN_JOB_CLEAR_DESC,
		/// <summary>
		/// 涉猎
		/// </summary>
		VILLAGE_SKILL_DABBLING,
		/// <summary>
		/// 新手
		/// </summary>
		VILLAGE_SKILL_NOVICE,
		/// <summary>
		/// 合格
		/// </summary>
		VILLAGE_SKILL_ADEQUATE,
		/// <summary>
		/// 胜任
		/// </summary>
		VILLAGE_SKILL_COMPETENT,
		/// <summary>
		/// 熟练
		/// </summary>
		VILLAGE_SKILL_SKILLED,
		/// <summary>
		/// 专家
		/// </summary>
		VILLAGE_SKILL_PROFICIENT,
		/// <summary>
		/// 大师
		/// </summary>
		VILLAGE_SKILL_MASTER,
		/// <summary>
		/// 创世主
		/// </summary>
		VILLAGE_TAB_TITLE_DEITIES,
		/// <summary>
		/// 古神
		/// </summary>
		VILLAGE_TAB_TITLE_ELDERS,
		/// <summary>
		/// 银河联盟
		/// </summary>
		VILLAGE_TAB_TITLE_UNION,
		/// <summary>
		/// 行星议会
		/// </summary>
		VILLAGE_TAB_TITLE_COUNCIL,
		/// <summary>
		/// 星际联合
		/// </summary>
		VILLAGE_TAB_TITLE_CONSORTIUM,
		/// <summary>
		/// 文明
		/// </summary>
		VILLAGE_TAB_TITLE_CIVILISATION,
		/// <summary>
		/// 社会
		/// </summary>
		VILLAGE_TAB_TITLE_SOCIETY,
		/// <summary>
		/// 大帝国
		/// </summary>
		VILLAGE_TAB_TITLE_REICH,
		/// <summary>
		/// 联邦
		/// </summary>
		VILLAGE_TAB_TITLE_FEDERATION,
		/// <summary>
		/// 霸权
		/// </summary>
		VILLAGE_TAB_TITLE_HEGEMONY,
		/// <summary>
		/// 自治领
		/// </summary>
		VILLAGE_TAB_TITLE_DOMINION,
		/// <summary>
		/// 帝国
		/// </summary>
		VILLAGE_TAB_TITLE_IMPERIUM,
		/// <summary>
		/// 王国
		/// </summary>
		VILLAGE_TAB_TITLE_EMPIRE,
		/// <summary>
		/// 城邦
		/// </summary>
		VILLAGE_TAB_TITLE_MEGAPOLIS,
		/// <summary>
		/// 都市
		/// </summary>
		VILLAGE_TAB_TITLE_METROPOLIS,
		/// <summary>
		/// 城市
		/// </summary>
		VILLAGE_TAB_TITLE_CITY,
		/// <summary>
		/// 城镇
		/// </summary>
		VILLAGE_TAB_TITLE_TOWN,
		/// <summary>
		/// 小镇
		/// </summary>
		VILLAGE_TAB_TITLE_SMALLTOWN,
		/// <summary>
		/// 殖民地
		/// </summary>
		VILLAGE_TAB_TITLE_SETTLEMENT,
		/// <summary>
		/// 村镇
		/// </summary>
		VILLAGE_TAB_TITLE_VILLAGE,
		/// <summary>
		/// 小村庄
		/// </summary>
		VILLAGE_TAB_TITLE_SMALLVILLAGE,
		/// <summary>
		/// 边区村落
		/// </summary>
		VILLAGE_TAB_TITLE_OUTPOST,
		/// <summary>
		/// 你得到了 1 只独角兽!
		/// </summary>
		VILLAGE_NEW_ONE_UNICORN,
		/// <summary>
		/// 你得到了 {0} 只独角兽!
		/// </summary>
		VILLAGE_NEW_MANY_UNICORNS,
		/// <summary>
		/// 我们真是可爱，直到猎物死掉之前都只是惬意地对着它们咕噜咕噜
		/// </summary>
		VILLAGE_JOB_HUNTER_FLAVOR,
		/// <summary>
		/// 我始终不明白我们怎么用肉球挖矿的
		/// </summary>
		VILLAGE_JOB_MINER_FLAVOR,
		/// <summary>
		/// 绝对. 不要. 乱抓.
		/// </summary>
		VILLAGE_WOODCUTTER_FLAVOR,
		/// <summary>
		/// 你的领袖提拔了 1 只小猫
		/// </summary>
		VILLAGE_LEADER_PROMOTED_ONE_KITTEN,
		/// <summary>
		/// 你的领袖提拔了 {0} 只小猫
		/// </summary>
		VILLAGE_LEADER_PROMOTED_MANY_KITTENS,
		/// <summary>
		/// 空闲的小猫
		/// </summary>
		VILLAGE_GENERAL_FREE_KITTENS_LABEL,
		/// <summary>
		/// 你的小猫已经达到当前最高等级
		/// </summary>
		VILLAGE_KITTENS_HAVE_BEST_RANK,
		/// <summary>
		/// 没有足够的黄金来提拔小猫
		/// </summary>
		VILLAGE_KITTENS_PROMOTION_NOGOLD,
		/// <summary>
		/// 一只小猫加入了你的村庄
		/// </summary>
		VILLAGE_MSG_KITTEN_HAS_JOINED,
		/// <summary>
		/// 你确定吗?
		/// </summary>
		VILLAGE_TAB_CLEAR_JOB_CONFIRMATION_MSG,
		/// <summary>
		/// 化学家
		/// </summary>
		VILLAGE_TRAIT_CHEMIST,
		/// <summary>
		/// 工匠
		/// </summary>
		VILLAGE_TRAIT_ENGINEER,
		/// <summary>
		/// 管理者
		/// </summary>
		VILLAGE_TRAIT_MANAGER,
		/// <summary>
		/// 商人
		/// </summary>
		VILLAGE_TRAIT_MERCHANT,
		/// <summary>
		/// 冶金学家
		/// </summary>
		VILLAGE_TRAIT_METALLURGIST,
		/// <summary>
		/// 无特质
		/// </summary>
		VILLAGE_TRAIT_NONE,
		/// <summary>
		/// 科学家
		/// </summary>
		VILLAGE_TRAIT_SCIENTIST,
		/// <summary>
		/// 哲学家
		/// </summary>
		VILLAGE_TRAIT_WISE,
		/// <summary>
		/// 所有特质
		/// </summary>
		VILLAGE_TRAIT_FILTER_ALL,
		/// <summary>
		/// 小猫总计
		/// </summary>
		STATS_KITTENS_TOTAL,
		/// <summary>
		/// 小猫死亡
		/// </summary>
		STATS_KITTENS_DEAD,
		/// <summary>
		/// 游戏总年数
		/// </summary>
		STATS_YEARS_TOTAL,
		/// <summary>
		/// 周目数
		/// </summary>
		STATS_RUN_NUMBER,
		/// <summary>
		/// 领导力总数
		/// </summary>
		STATS_PARAGON_TOTAL,
		/// <summary>
		/// 罕见事件观察次数
		/// </summary>
		STATS_EVENTS_TOTAL,
		/// <summary>
		/// 献祭独角兽
		/// </summary>
		STATS_UNICORNS,
		/// <summary>
		/// 建造建筑
		/// </summary>
		STATS_BUILDINGS,
		/// <summary>
		/// 累计点击总数
		/// </summary>
		STATS_CLICKS_TOTAL,
		/// <summary>
		/// 累计贸易完成次数
		/// </summary>
		STATS_TRADES_TOTAL,
		/// <summary>
		/// 累计工艺制作次数
		/// </summary>
		STATS_CRAFTS_TOTAL,
		/// <summary>
		/// 小猫平均出生 (每世纪)
		/// </summary>
		STATS_KITTENS_AVG,
		/// <summary>
		/// 贸易完成次数
		/// </summary>
		STATS_TRADES_CURRENT,
		/// <summary>
		/// 工艺制作次数
		/// </summary>
		STATS_CRAFTS_CURRENT,
		/// <summary>
		/// 小猫平均出生 (每世纪)
		/// </summary>
		STATS_KITTENS_CURRENT,
		/// <summary>
		/// 游戏时间
		/// </summary>
		STATS_TIME_CURRENT,
		/// <summary>
		/// 全局统计
		/// </summary>
		STATS_GROUP_ALL,
		/// <summary>
		/// 当前游戏状态
		/// </summary>
		STATS_GROUP_CURRENT,
		/// <summary>
		/// 重启游戏，进入半衰期时间\n\n目标:抵达第 1000 年
		/// </summary>
		CHALLENDGE_1000YEARS_DESC,
		/// <summary>
		/// 燃烧时间水晶释放的热量减少
		/// </summary>
		CHALLENDGE_1000YEARS_EFFECT_DESC,
		/// <summary>
		/// 千禧年
		/// </summary>
		CHALLENDGE_1000YEARS_LABEL,
		/// <summary>
		/// 重启游戏，小猫将以自己的方式生活:小猫变懒惰，消耗额外的猫薄荷，且不能指定为领袖。\n\n目标:建造 AI 核心
		/// </summary>
		CHALLENDGE_ANARCHY_DESC,
		/// <summary>
		/// 获得业力时将以 2 倍计算小猫数量
		/// </summary>
		CHALLENDGE_ANARCHY_EFFECT_DESC,
		/// <summary>
		/// 无政府状态
		/// </summary>
		CHALLENDGE_ANARCHY_LABEL,
		/// <summary>
		/// 重启游戏，没有信仰加成。\n\n目标:带着至少一个冷冻仓重置游戏
		/// </summary>
		CHALLENDGE_ATHEISM_DESC,
		/// <summary>
		/// 每个超越等级将信仰加成的上限提升 100% (相当于 20 级黑方尖碑)
		/// </summary>
		CHALLENDGE_ATHEISM_EFFECT_DESC,
		/// <summary>
		/// 无神论
		/// </summary>
		CHALLENDGE_ATHEISM_LABEL,
		/// <summary>
		/// 你将不能获得超时空传送仪的重置效果
		/// </summary>
		CHALLENDGE_BTN_CHRONOSPHERE_DESC,
		/// <summary>
		/// 你将不能获得超时空传送仪的重置效果。\n警告:超时空传送仪的重置效果将自动关闭钢铁意志模式。
		/// </summary>
		CHALLENDGE_BTN_CHRONOSPHERE_WITH_IRONWILL_DESC,
		/// <summary>
		/// 你确定要重置当前游戏并开始此挑战吗?
		/// </summary>
		CHALLENDGE_BTN_CONFIRMATION_MSG,
		/// <summary>
		/// 确认挑战
		/// </summary>
		CHALLENDGE_BTN_CONFIRMATION_TITLE,
		/// <summary>
		/// \n奖励:{0}\n\n为开启此挑战，当前游戏将被重置。 {1}
		/// </summary>
		CHALLENDGE_BTN_DESC,
		/// <summary>
		/// 恭喜你!你完成了挑战: {0}.
		/// </summary>
		CHALLENDGE_BTN_LOG_MESSAGE_ON_COMPLETE,
		/// <summary>
		/// {0} (已完成)
		/// </summary>
		CHALLENDGE_BTN_NAME_COMPLETE,
		/// <summary>
		/// {0} (进行中)
		/// </summary>
		CHALLENDGE_BTN_NAME_CURRENT,
		/// <summary>
		/// 重启游戏，能源消耗变为 2 倍。\n\n目标:解锁所有能源生产建筑，并至少各建造一级
		/// </summary>
		CHALLENDGE_ENERGY_DESC,
		/// <summary>
		/// 能源短缺的生产惩罚减半
		/// </summary>
		CHALLENDGE_ENERGY_EFFECT_DESC,
		/// <summary>
		/// 能源
		/// </summary>
		CHALLENDGE_ENERGY_LABEL,
		/// <summary>
		/// 钢铁意志是一个有点隐藏的挑战，你不需要点击这里就能进行:重启游戏，在没有小猫的情况下进行游戏
		/// </summary>
		CHALLENDGE_IRONWILL_DESC,
		/// <summary>
		/// 什么都没有
		/// </summary>
		CHALLENDGE_IRONWILL_EFFECT_DESC,
		/// <summary>
		/// 钢铁意志
		/// </summary>
		CHALLENDGE_IRONWILL_LABEL,
		/// <summary>
		/// 重启游戏，只有冬天:猫薄荷不会受到领导力的生产加成\n\n目标:到达太阳
		/// </summary>
		CHALLENDGE_WINTERISCOMING_DESC,
		/// <summary>
		/// 温暖季节出现的机会增加，寒冷季节出现的机会减少
		/// </summary>
		CHALLENDGE_WINTERISCOMING_EFFECT_DESC,
		/// <summary>
		/// 冬天来了
		/// </summary>
		CHALLENDGE_WINTERISCOMING_LABEL,
		/// <summary>
		/// 挑战
		/// </summary>
		CHALLENDGE_PANEL_LABEL,
		/// <summary>
		/// 半人马座星系是一个温暖而遥远的星系
		/// </summary>
		SPACE_CENTAURUSSYSTEMMISSION_DESC,
		/// <summary>
		/// 探索半人马座星系
		/// </summary>
		SPACE_CENTAURUSSYSTEMMISSION_LABEL,
		/// <summary>
		/// 沙丘是一颗巨大但无生命的行星，表面被沙子和火山岩覆盖
		/// </summary>
		SPACE_DUNEMISSION_DESC,
		/// <summary>
		/// 探索沙丘星
		/// </summary>
		SPACE_DUNEMISSION_LABEL,
		/// <summary>
		/// 宇宙的尽头
		/// </summary>
		SPACE_FURTHESTRINGMISSION_DESC,
		/// <summary>
		/// 飞向边界环
		/// </summary>
		SPACE_FURTHESTRINGMISSION_LABEL,
		/// <summary>
		/// 地面控制
		/// </summary>
		SPACE_GROUND_CONTROL_LABEL,
		/// <summary>
		/// 太阳是位于喵太阳系中心的 G2V 型主序星
		/// </summary>
		SPACE_HELIOSMISSION_DESC,
		/// <summary>
		/// 探索太阳
		/// </summary>
		SPACE_HELIOSMISSION_LABEL,
		/// <summary>
		/// 开罗是喵太阳系尽头的一颗矮行星
		/// </summary>
		SPACE_KAIROMISSION_DESC,
		/// <summary>
		/// 探索开罗星
		/// </summary>
		SPACE_KAIROMISSION_LABEL,
		/// <summary>
		/// {0} (已完成)
		/// </summary>
		SPACE_MISSION_NAME_COMPLETE,
		/// <summary>
		/// {0} (进行中)
		/// </summary>
		SPACE_MISSION_NAME_INPROGRESS,
		/// <summary>
		/// 罗夏彗星无法到达，但你现在能看到更远的地方了
		/// </summary>
		SPACE_MISSION_RORSCHACH_COMPLETE_LOG_MSG,
		/// <summary>
		/// 月球是喵星的卫星\n向红月亮发射一枚火箭
		/// </summary>
		SPACE_MOONMISSION_DESC,
		/// <summary>
		/// 探索月球
		/// </summary>
		SPACE_MOONMISSION_LABEL,
		/// <summary>
		/// 你到达了一颗新的星球!
		/// </summary>
		SPACE_NEWPLANET_LOG_MSG,
		/// <summary>
		/// 向太空发射一枚火箭
		/// </summary>
		SPACE_ORBITALLAUNCH_DESC,
		/// <summary>
		/// 冲出轨道
		/// </summary>
		SPACE_ORBITALLAUNCH_LABEL,
		/// <summary>
		/// 罗夏彗星
		/// </summary>
		SPACE_PANEL_RORSHACH_LABEL,
		/// <summary>
		/// 碧池是一颗巨型水行星，由酸性星体和甲烷大气组成
		/// </summary>
		SPACE_PISCINEMISSION_DESC,
		/// <summary>
		/// 探索碧池星
		/// </summary>
		SPACE_PISCINEMISSION_LABEL,
		/// <summary>
		/// 喵星
		/// </summary>
		SPACE_PLANET_CATH_LABEL,
		/// <summary>
		/// 部署一颗卫星。卫星使天文台的效能提升 5% 同时产出星图
		/// </summary>
		SPACE_PLANET_CATH_SATTELITE_DESC,
		/// <summary>
		/// 卫星
		/// </summary>
		SPACE_PLANET_CATH_SATTELITE_LABEL,
		/// <summary>
		/// 每级太空电梯将降低太空飞行计划 5% 的石油需求，同时使所有太空建筑的产能提升 1%
		/// </summary>
		SPACE_PLANET_CATH_SPACEELEVATOR_DESC,
		/// <summary>
		/// 太空电梯
		/// </summary>
		SPACE_PLANET_CATH_SPACEELEVATOR_LABEL,
		/// <summary>
		/// 部署一座空间站。每级空间站增加科学产出并提供 2 名宇航员的居住空间
		/// </summary>
		SPACE_PLANET_CATH_SPACESTATION_DESC,
		/// <summary>
		/// 空间站
		/// </summary>
		SPACE_PLANET_CATH_SPACESTATION_LABEL,
		/// <summary>
		/// 半人马座星系
		/// </summary>
		SPACE_PLANET_CENTAURUSSYSTEM_LABEL,
		/// <summary>
		/// 撕裂半人马座恒星附近的行星收集熔岩能量
		/// </summary>
		SPACE_PLANET_CENTAURUSSYSTEM_TECTONIC_DESC,
		/// <summary>
		/// 构造体
		/// </summary>
		SPACE_PLANET_CENTAURUSSYSTEM_TECTONIC_LABEL,
		/// <summary>
		/// 产生高压油流。每级太空电梯为空间石油产能提供数值等于全局生产加成 0.1% 的额外增益
		/// </summary>
		SPACE_PLANET_DUNE_HYDROFRACTURER_DESC,
		/// <summary>
		/// 流体切割
		/// </summary>
		SPACE_PLANET_DUNE_HYDROFRACTURER_LABEL,
		/// <summary>
		/// 沙丘
		/// </summary>
		SPACE_PLANET_DUNE_LABEL,
		/// <summary>
		/// USS 采矿船喵村号可以裂解整个星球
		/// </summary>
		SPACE_PLANET_DUNE_PLANETCRACKER_DESC,
		/// <summary>
		/// 星球裂解
		/// </summary>
		SPACE_PLANET_DUNE_PLANETCRACKER_LABEL,
		/// <summary>
		/// 从沙丘星的沙中提取出一种高度精神活性物质，也就是俗称的「香料」
		/// </summary>
		SPACE_PLANET_DUNE_SPICEREFINERY_DESC,
		/// <summary>
		/// 香料提取
		/// </summary>
		SPACE_PLANET_DUNE_SPICEREFINERY_LABEL,
		/// <summary>
		/// 边界环
		/// </summary>
		SPACE_PLANET_FURTHESTRING_LABEL,
		/// <summary>
		/// 收容室。将反物质存储上限提高 100 点
		/// </summary>
		SPACE_PLANET_HELIOS_CONTAINMENTCHAMBER_DESC,
		/// <summary>
		/// 收容室
		/// </summary>
		SPACE_PLANET_HELIOS_CONTAINMENTCHAMBER_LABEL,
		/// <summary>
		/// 太阳
		/// </summary>
		SPACE_PLANET_HELIOS_LABEL,
		/// <summary>
		/// 每年产出一次反物质，能源短缺状态下不工作
		/// </summary>
		SPACE_PLANET_HELIOS_SUNLIFTER_DESC,
		/// <summary>
		/// 太阳提取
		/// </summary>
		SPACE_PLANET_HELIOS_SUNLIFTER_LABEL,
		/// <summary>
		/// 开罗
		/// </summary>
		SPACE_PLANET_KAIRO_LABEL,
		/// <summary>
		/// 反物质能源驱动的空间站，用于科学研究和星际导航
		/// </summary>
		SPACE_PLANET_KAIRO_SPACEBEACON_DESC,
		/// <summary>
		/// 太空灯塔
		/// </summary>
		SPACE_PLANET_KAIRO_SPACEBEACON_LABEL,
		/// <summary>
		/// 月球
		/// </summary>
		SPACE_PLANET_MOON_LABEL,
		/// <summary>
		/// 在红月亮的月面上建立一座基地
		/// </summary>
		SPACE_PLANET_MOON_MOONBASE_DESC,
		/// <summary>
		/// 月球基地
		/// </summary>
		SPACE_PLANET_MOON_MOONBASE_LABEL,
		/// <summary>
		/// 在红月亮上部署一座核动力的采矿前哨
		/// </summary>
		SPACE_PLANET_MOON_MOONOUTPOST_DESC,
		/// <summary>
		/// 月球前哨
		/// </summary>
		SPACE_PLANET_MOON_MOONOUTPOST_LABEL,
		/// <summary>
		/// 碧池
		/// </summary>
		SPACE_PLANET_PISCINE_LABEL,
		/// <summary>
		/// 所有空间建筑的产能提升 2%
		/// </summary>
		SPACE_PLANET_PISCINE_ORBITALARRAY_DESC,
		/// <summary>
		/// 轨道阵列
		/// </summary>
		SPACE_PLANET_PISCINE_ORBITALARRAY_LABEL,
		/// <summary>
		/// 可移动的太空科研船
		/// </summary>
		SPACE_PLANET_PISCINE_RESEARCHVESSEL_DESC,
		/// <summary>
		/// 科研船
		/// </summary>
		SPACE_PLANET_PISCINE_RESEARCHVESSEL_LABEL,
		/// <summary>
		/// 一座庞大的复合存储设施
		/// </summary>
		SPACE_PLANET_TERMINUS_CRYOSTATION_DESC,
		/// <summary>
		/// 低温储存站
		/// </summary>
		SPACE_PLANET_TERMINUS_CRYOSTATION_LABEL,
		/// <summary>
		/// 终焉
		/// </summary>
		SPACE_PLANET_TERMINUS_LABEL,
		/// <summary>
		/// 应用最尖端技术的自动化水栽培系统。猫薄荷存储上限增加 10%，猫薄荷产量增加 2.5%
		/// </summary>
		SPACE_PLANET_YARN_HYDROPONICS_DESC,
		/// <summary>
		/// 水栽培
		/// </summary>
		SPACE_PLANET_YARN_HYDROPONICS_LABEL,
		/// <summary>
		/// 纱星
		/// </summary>
		SPACE_PLANET_YARN_LABEL,
		/// <summary>
		/// 引爆反物质融化纱星的冰层，将氧气释放到大气中
		/// </summary>
		SPACE_PLANET_YARN_TERRAFORMINGSTATION_DESC,
		/// <summary>
		/// 星球改造站
		/// </summary>
		SPACE_PLANET_YARN_TERRAFORMINGSTATION_LABEL,
		/// <summary>
		/// 罗夏是太阳附近最大的彗星
		/// </summary>
		SPACE_RORSCHACHMISSION_DESC,
		/// <summary>
		/// 探索罗夏彗星
		/// </summary>
		SPACE_RORSCHACHMISSION_LABEL,
		/// <summary>
		/// 隐藏已完成的探索计划
		/// </summary>
		SPACE_TAB_HIDE_COMPLETE_MISSIONS,
		/// <summary>
		/// 终焉星是位于喵太阳系远端的一颗超大质量的冰巨星
		/// </summary>
		SPACE_TERMINUSMISSION_DESC,
		/// <summary>
		/// 探索终焉星
		/// </summary>
		SPACE_TERMINUSMISSION_LABEL,
		/// <summary>
		/// 纱星是一颗拥有适宜气候、海洋和含氧大气的类地行星
		/// </summary>
		SPACE_YARNMISSION_DESC,
		/// <summary>
		/// 探索纱星
		/// </summary>
		SPACE_YARNMISSION_LABEL,
		/// <summary>
		/// TBD.
		/// </summary>
		VOID_SPACECATHEDRAL_DESC,
		/// <summary>
		/// 太空大教堂
		/// </summary>
		VOID_SPACECATHEDRAL_LABEL,
		/// <summary>
		/// 所有价格比率降低 1% (使建筑价格增长变慢)，解锁更多价格升级
		/// </summary>
		PRESTIGE_ENGENEERING_DESC,
		/// <summary>
		/// 工程学
		/// </summary>
		PRESTIGE_ENGENEERING_LABEL,
		/// <summary>
		/// 手稿的工艺制作比率提升 25%
		/// </summary>
		PRESTIGE_CODEXVOX_DESC,
		/// <summary>
		/// 声音法典
		/// </summary>
		PRESTIGE_CODEXVOX_LABEL,
		/// <summary>
		/// 概要的工艺制作比率提升 25%
		/// </summary>
		PRESTIGE_CODEXLOGOS_DESC,
		/// <summary>
		/// 文字法典
		/// </summary>
		PRESTIGE_CODEXLOGOS_LABEL,
		/// <summary>
		/// 蓝图的工艺制作比率提升 25%
		/// </summary>
		PRESTIGE_CODEXAGRUM_DESC,
		/// <summary>
		/// 语言法典
		/// </summary>
		PRESTIGE_CODEXAGRUM_LABEL,
		/// <summary>
		/// 解锁额外的超级建筑
		/// </summary>
		PRESTIGE_MEGALOMANIA_DESC,
		/// <summary>
		/// 狂妄自大
		/// </summary>
		PRESTIGE_MEGALOMANIA_LABEL,
		/// <summary>
		/// 解锁独角兽墓园
		/// </summary>
		PRESTIGE_BLACKCODEX_DESC,
		/// <summary>
		/// 黑之法典
		/// </summary>
		PRESTIGE_BLACKCODEX_LABEL,
		/// <summary>
		/// 所有价格比率降低 ~1.618%
		/// </summary>
		PRESTIGE_GOLDENRATIO_DESC,
		/// <summary>
		/// 黄金比率
		/// </summary>
		PRESTIGE_GOLDENRATIO_LABEL,
		/// <summary>
		/// 所有价格比率降低 1.7%
		/// </summary>
		PRESTIGE_DIVINEPROPORTION_DESC,
		/// <summary>
		/// 神圣比例
		/// </summary>
		PRESTIGE_DIVINEPROPORTION_LABEL,
		/// <summary>
		/// 所有价格比率降低 2%
		/// </summary>
		PRESTIGE_VITRUVIANFELINE_DESC,
		/// <summary>
		/// 维特鲁威猫
		/// </summary>
		PRESTIGE_VITRUVIANFELINE_LABEL,
		/// <summary>
		/// 所有价格比率降低 2.25%
		/// </summary>
		PRESTIGE_RENAISSANCE_DESC,
		/// <summary>
		/// 文艺复兴
		/// </summary>
		PRESTIGE_RENAISSANCE_LABEL,
		/// <summary>
		/// 更早发现其他种族，大幅改善种族地位。解锁更多贸易升级
		/// </summary>
		PRESTIGE_DIPLOMACY_DESC,
		/// <summary>
		/// 外交手段
		/// </summary>
		PRESTIGE_DIPLOMACY_LABEL,
		/// <summary>
		/// 一些斑马猎人将留在村子里 (解锁斑马猎人后才能产生效果)
		/// </summary>
		PRESTIGE_ZEBRADIPLOMACY_DESC,
		/// <summary>
		/// 斑马外交
		/// </summary>
		PRESTIGE_ZEBRADIPLOMACY_LABEL,
		/// <summary>
		/// 更多的斑马将会留下
		/// </summary>
		PRESTIGE_ZEBRACOVENANT_DESC,
		/// <summary>
		/// 斑马盟约
		/// </summary>
		PRESTIGE_ZEBRACOVENANT_LABEL,
		/// <summary>
		/// 流星和天文事件将会发生得更频繁
		/// </summary>
		PRESTIGE_CHRONOMANCY_DESC,
		/// <summary>
		/// 时光占卜
		/// </summary>
		PRESTIGE_CHRONOMANCY_LABEL,
		/// <summary>
		/// 天文事件的发生概率和天文台的效能翻倍
		/// </summary>
		PRESTIGE_ASTROMANCY_DESC,
		/// <summary>
		/// 占星术
		/// </summary>
		PRESTIGE_ASTROMANCY_LABEL,
		/// <summary>
		/// 独角兽裂隙和象牙流星发生得更频繁
		/// </summary>
		PRESTIGE_UNICORNMANCY_DESC,
		/// <summary>
		/// 独角兽占卜
		/// </summary>
		PRESTIGE_UNICORNMANCY_LABEL,
		/// <summary>
		/// 时间水晶和时空物理学将在游戏重置时保留
		/// </summary>
		PRESTIGE_ANACHRONOMANCY_DESC,
		/// <summary>
		/// 回溯时空学
		/// </summary>
		PRESTIGE_ANACHRONOMANCY_LABEL,
		/// <summary>
		/// 节日的持续时间可以叠加
		/// </summary>
		PRESTIGE_CARNIVALS_DESC,
		/// <summary>
		/// 嘉年华
		/// </summary>
		PRESTIGE_CARNIVALS_LABEL,
		/// <summary>
		/// 小猫到来的速度加快 75％
		/// </summary>
		PRESTIGE_WILLENFLUFF_DESC,
		/// <summary>
		/// 维伦多尔夫的喵纳斯
		/// </summary>
		PRESTIGE_WILLENFLUFF_LABEL,
		/// <summary>
		/// 小猫到来的速度额外加快 150％
		/// </summary>
		PRESTIGE_PAWGAN_DESC,
		/// <summary>
		/// 异教仪式
		/// </summary>
		PRESTIGE_PAWGAN_LABEL,
		/// <summary>
		/// 不同的年份会有不同的特殊效果
		/// </summary>
		PRESTIGE_NUMEROLOGY_DESC,
		/// <summary>
		/// 灵数哲学
		/// </summary>
		PRESTIGE_NUMEROLOGY_LABEL,
		/// <summary>
		/// 不同的年份在节日期间会有额外的特殊效果
		/// </summary>
		PRESTIGE_NUMEROMANCY_DESC,
		/// <summary>
		/// 数理占卜
		/// </summary>
		PRESTIGE_NUMEROMANCY_LABEL,
		/// <summary>
		/// 领导力的效能增加 5％
		/// </summary>
		PRESTIGE_MALKUTH_DESC,
		/// <summary>
		/// Malkuth
		/// </summary>
		PRESTIGE_MALKUTH_LABEL,
		/// <summary>
		/// 领导力的效能增加 5％
		/// </summary>
		PRESTIGE_YESOD_DESC,
		/// <summary>
		/// Yesod
		/// </summary>
		PRESTIGE_YESOD_LABEL,
		/// <summary>
		/// 领导力的效能增加 5％
		/// </summary>
		PRESTIGE_HOD_DESC,
		/// <summary>
		/// Hod
		/// </summary>
		PRESTIGE_HOD_LABEL,
		/// <summary>
		/// 领导力的效能增加 5％
		/// </summary>
		PRESTIGE_NETZACH_DESC,
		/// <summary>
		/// Netzach
		/// </summary>
		PRESTIGE_NETZACH_LABEL,
		/// <summary>
		/// 领导力的效能增加 5％
		/// </summary>
		PRESTIGE_TIFERET_DESC,
		/// <summary>
		/// Tiferet
		/// </summary>
		PRESTIGE_TIFERET_LABEL,
		/// <summary>
		/// 领导力的效能增加 5％
		/// </summary>
		PRESTIGE_GEVURAH_DESC,
		/// <summary>
		/// Gevurah
		/// </summary>
		PRESTIGE_GEVURAH_LABEL,
		/// <summary>
		/// 领导力的效能增加 5％
		/// </summary>
		PRESTIGE_CHESED_DESC,
		/// <summary>
		/// Chesed
		/// </summary>
		PRESTIGE_CHESED_LABEL,
		/// <summary>
		/// 领导力的效能增加 5％
		/// </summary>
		PRESTIGE_BINAH_DESC,
		/// <summary>
		/// Binah
		/// </summary>
		PRESTIGE_BINAH_LABEL,
		/// <summary>
		/// 领导力的效能增加 5％
		/// </summary>
		PRESTIGE_CHOKHMAH_DESC,
		/// <summary>
		/// Chokhmah
		/// </summary>
		PRESTIGE_CHOKHMAH_LABEL,
		/// <summary>
		/// 领导力的效能增加 5％
		/// </summary>
		PRESTIGE_KETER_DESC,
		/// <summary>
		/// Keter
		/// </summary>
		PRESTIGE_KETER_LABEL,
		/// <summary>
		/// 添加10％产生的信仰，该信仰会自动累积
		/// </summary>
		PRESTIGE_VOIDORDER_DESC,
		/// <summary>
		/// 虚空圣典
		/// </summary>
		PRESTIGE_VOIDORDER_LABEL,
		/// <summary>
		/// 解开额外的游戏挑战
		/// </summary>
		PRESTIGE_ADJUSTMENTBUREAU_DESC,
		/// <summary>
		/// 仲裁局
		/// </summary>
		PRESTIGE_ADJUSTMENTBUREAU_LABEL,
		/// <summary>
		/// 燃烧领导力
		/// </summary>
		PRESTIGE_BTN_BURNPARAGON_LABEL,
		/// <summary>
		/// 舍弃所有的领导力
		/// </summary>
		PRESTIGE_BTN_BURNPARAGON_DESC,
		/// <summary>
		/// 玄学
		/// </summary>
		PRESTIGE_PANEL_LABEL,
		/// <summary>
		/// 隐藏已完成的科技
		/// </summary>
		SCIENCE_TOGGLERESEARCHED_LABEL,
		/// <summary>
		/// 发展预测季节更替的能力，这项能力对农业的进步至关重要
		/// </summary>
		SCIENCE_CALENDAR_DESC,
		/// <summary>
		/// 历法提供了更准确的时间记算方式
		/// </summary>
		SCIENCE_CALENDAR_EFFECTDESC,
		/// <summary>
		/// 又忘记今天是周几了?
		/// </summary>
		SCIENCE_CALENDAR_FLAVOR,
		/// <summary>
		/// 历法
		/// </summary>
		SCIENCE_CALENDAR_LABEL,
		/// <summary>
		/// 作为所有文明生活的根基，农业使通过劳作获取食物成为可能。农业可以显著提高粮食的产出
		/// </summary>
		SCIENCE_AGRICULTURE_DESC,
		/// <summary>
		/// 解锁农民和粮仓
		/// </summary>
		SCIENCE_AGRICULTURE_EFFECTDESC,
		/// <summary>
		/// 除了切片面包之外最好的东西!
		/// </summary>
		SCIENCE_AGRICULTURE_FLAVOR,
		/// <summary>
		/// 农业
		/// </summary>
		SCIENCE_AGRICULTURE_LABEL,
		/// <summary>
		/// 众所周知，远程武器被称为「弓」
		/// </summary>
		SCIENCE_ARCHERY_DESC,
		/// <summary>
		/// 解锁猎人
		/// </summary>
		SCIENCE_ARCHERY_EFFECTDESC,
		/// <summary>
		/// 箭术
		/// </summary>
		SCIENCE_ARCHERY_LABEL,
		/// <summary>
		/// TBD
		/// </summary>
		SCIENCE_ARCHERY_FLAVOR,
		/// <summary>
		/// 采矿业发展了从喵星内部获取矿物资源的能力
		/// </summary>
		SCIENCE_MINING_DESC,
		/// <summary>
		/// 解锁矿井
		/// </summary>
		SCIENCE_MINING_EFFECTDESC,
		/// <summary>
		/// 矿镐用对生拇指才会更容易握住
		/// </summary>
		SCIENCE_MINING_FLAVOR,
		/// <summary>
		/// 采矿
		/// </summary>
		SCIENCE_MINING_LABEL,
		/// <summary>
		/// 最初的金属加工技术，为新生文明提供了结实耐用的工具
		/// </summary>
		SCIENCE_METAL_DESC,
		/// <summary>
		/// 解锁熔炉，可以将矿物转化为金属
		/// </summary>
		SCIENCE_METAL_EFFECTDESC,
		/// <summary>
		/// 金属加工
		/// </summary>
		SCIENCE_METAL_LABEL,
		/// <summary>
		/// 通过在牧场进行驯养让各种动物资源进入了菜单。改善了食物生产
		/// </summary>
		SCIENCE_ANIMAL_DESC,
		/// <summary>
		/// 解锁牧场
		/// </summary>
		SCIENCE_ANIMAL_EFFECTDESC,
		/// <summary>
		/// 畜牧
		/// </summary>
		SCIENCE_ANIMAL_LABEL,
		/// <summary>
		/// 猫薄荷加工是一种非强制性技术，可以改进猫薄荷转化为木材的过程
		/// </summary>
		SCIENCE_BREWERY_DESC,
		/// <summary>
		/// 解锁猫薄荷浓缩
		/// </summary>
		SCIENCE_BREWERY_EFFECTDESC,
		/// <summary>
		/// 猫薄荷加工
		/// </summary>
		SCIENCE_BREWERY_LABEL,
		/// <summary>
		/// 由于能够更好地管理猫口，建立一个真正的政府机构将带来诸多便利
		/// </summary>
		SCIENCE_CIVIL_DESC,
		/// <summary>
		/// 解锁有关猫口的详细信息
		/// </summary>
		SCIENCE_CIVIL_EFFECTDESC,
		/// <summary>
		/// 牧猫专家
		/// </summary>
		SCIENCE_CIVIL_FLAVOR,
		/// <summary>
		/// 行政部门
		/// </summary>
		SCIENCE_CIVIL_LABEL,
		/// <summary>
		/// 数学是所有自然科学的基础之基础。促进科学的发展
		/// </summary>
		SCIENCE_MATH_DESC,
		/// <summary>
		/// 解锁研究院，这是种高效的科研建筑
		/// </summary>
		SCIENCE_MATH_EFFECTDESC,
		/// <summary>
		/// 猫的呼噜等于喵倍的猫爪的平方
		/// </summary>
		SCIENCE_MATH_FLAVOR,
		/// <summary>
		/// 数学
		/// </summary>
		SCIENCE_MATH_LABEL,
		/// <summary>
		/// 建筑代表了对砖石结构研究的进步，主要体现在建设者的工具箱中多了铁和其他金属。狩猎和基础建设都将受其影响
		/// </summary>
		SCIENCE_CONSTRUCTION_DESC,
		/// <summary>
		/// 解锁木材厂和复合弓
		/// </summary>
		SCIENCE_CONSTRUCTION_EFFECTDESC,
		/// <summary>
		/// 把枕头城堡建得漂亮点!
		/// </summary>
		SCIENCE_CONSTRUCTION_FLAVOR,
		/// <summary>
		/// 建筑
		/// </summary>
		SCIENCE_CONSTRUCTION_LABEL,
		/// <summary>
		/// 工程是设计复杂材料、结构、设备和系统的科学(或者说艺术?)
		/// </summary>
		SCIENCE_ENGINEERING_DESC,
		/// <summary>
		/// 解锁水渠
		/// </summary>
		SCIENCE_ENGINEERING_EFFECTDESC,
		/// <summary>
		/// 工程
		/// </summary>
		SCIENCE_ENGINEERING_LABEL,
		/// <summary>
		/// 货币代表着一定数量的财富，能够以间接的方式显著促进发展
		/// </summary>
		SCIENCE_CURRENCY_DESC,
		/// <summary>
		/// 解锁黄金与贸易
		/// </summary>
		SCIENCE_CURRENCY_EFFECTDESC,
		/// <summary>
		/// 货币
		/// </summary>
		SCIENCE_CURRENCY_LABEL,
		/// <summary>
		/// 写作是在素材上记录信息的艺术，写作可以广泛影响文明的幸福和文化发展
		/// </summary>
		SCIENCE_WRITING_DESC,
		/// <summary>
		/// 解锁露天剧场
		/// </summary>
		SCIENCE_WRITING_EFFECTDESC,
		/// <summary>
		/// 写作使用的墨水比爪印少
		/// </summary>
		SCIENCE_WRITING_FLAVOR,
		/// <summary>
		/// 写作
		/// </summary>
		SCIENCE_WRITING_LABEL,
		/// <summary>
		/// 哲学是猫类最早发展出的抽象学科。哲学是精神和文化进步的基础
		/// </summary>
		SCIENCE_PHILOSOPHY_DESC,
		/// <summary>
		/// 解锁神殿
		/// </summary>
		SCIENCE_PHILOSOPHY_EFFECTDESC,
		/// <summary>
		/// 我喵故我在
		/// </summary>
		SCIENCE_PHILOSOPHY_FLAVOR,
		/// <summary>
		/// 哲学
		/// </summary>
		SCIENCE_PHILOSOPHY_LABEL,
		/// <summary>
		/// 金属加工与科技的发展推动了机械这种在一台设备上同时拥有多个可动部件的概念的诞生。机械引入了通过自动化减少重复操作的理念
		/// </summary>
		SCIENCE_MACHINERY_DESC,
		/// <summary>
		/// 解锁蒸汽工房，弩，印刷机和工厂自动化
		/// </summary>
		SCIENCE_MACHINERY_EFFECTDESC,
		/// <summary>
		/// 机械
		/// </summary>
		SCIENCE_MACHINERY_LABEL,
		/// <summary>
		/// 钢的应用进一步推动金属加工的进步。文明发展的方方面面都将从中获益
		/// </summary>
		SCIENCE_STEEL_DESC,
		/// <summary>
		/// 解锁煤和钢的生产
		/// </summary>
		SCIENCE_STEEL_EFFECTDESC,
		/// <summary>
		/// 钢
		/// </summary>
		SCIENCE_STEEL_LABEL,
		/// <summary>
		/// 神学是对宗教的研究，宗教是影响文化、科学和工业发展的关键概念。\n(提示:并非一次性需要这么多文化)
		/// </summary>
		SCIENCE_THEOLOGY_DESC,
		/// <summary>
		/// 解锁宗教
		/// </summary>
		SCIENCE_THEOLOGY_EFFECTDESC,
		/// <summary>
		/// 天上的火球究竟是什么?
		/// </summary>
		SCIENCE_THEOLOGY_FLAVOR,
		/// <summary>
		/// 神学
		/// </summary>
		SCIENCE_THEOLOGY_LABEL,
		/// <summary>
		/// 天文学是研究天体的科学。推动科学的发展
		/// </summary>
		SCIENCE_ASTRONOMY_DESC,
		/// <summary>
		/// 解锁天文台和星图
		/// </summary>
		SCIENCE_ASTRONOMY_EFFECTDESC,
		/// <summary>
		/// 天文学
		/// </summary>
		SCIENCE_ASTRONOMY_LABEL,
		/// <summary>
		/// 导航术推动了航海和造船技术的重大进步，促进经济发展，指引探索新文明的方向。\n(提示:并非一次性需要这么多文化)
		/// </summary>
		SCIENCE_NAVIGATION_DESC,
		/// <summary>
		/// 解锁贸易船的建造和跨海贸易
		/// </summary>
		SCIENCE_NAVIGATION_EFFECTDESC,
		/// <summary>
		/// 导航学
		/// </summary>
		SCIENCE_NAVIGATION_LABEL,
		/// <summary>
		/// 建筑学使得建造更加复杂的建筑成为可能
		/// </summary>
		SCIENCE_ARCHITECTURE_DESC,
		/// <summary>
		/// 解锁铸币厂和宅邸
		/// </summary>
		SCIENCE_ARCHITECTURE_EFFECTDESC,
		/// <summary>
		/// 更大更好的猫塔!
		/// </summary>
		SCIENCE_ARCHITECTURE_FLAVOR,
		/// <summary>
		/// 建筑学
		/// </summary>
		SCIENCE_ARCHITECTURE_LABEL,
		/// <summary>
		/// 物理学是研究自然规律的科学。主要是提升机械的效率
		/// </summary>
		SCIENCE_PHYSICS_DESC,
		/// <summary>
		/// 解锁一些有用的升级
		/// </summary>
		SCIENCE_PHYSICS_EFFECTDESC,
		/// <summary>
		/// 物理学
		/// </summary>
		SCIENCE_PHYSICS_LABEL,
		/// <summary>
		/// 形而上学是哲学的一门传统分支，专注于解释存在的本质和与之关联的世界。完全没用
		/// </summary>
		SCIENCE_METAPHYSICS_DESC,
		/// <summary>
		/// 什么都不做。
		/// </summary>
		SCIENCE_METAPHYSICS_EFFECTDESC,
		/// <summary>
		/// 玄学
		/// </summary>
		SCIENCE_METAPHYSICS_LABEL,
		/// <summary>
		/// 化学上的发现推动了对自然元素及其相互作用的深入研究和理解，因而可能解锁新的资源
		/// </summary>
		SCIENCE_CHEMISTRY_DESC,
		/// <summary>
		/// 解锁石油和油井
		/// </summary>
		SCIENCE_CHEMISTRY_EFFECTDESC,
		/// <summary>
		/// 化学
		/// </summary>
		SCIENCE_CHEMISTRY_LABEL,
		/// <summary>
		/// 声学是研究声音的科学。尽管用途不明显，但从长远来看能够推动文化与宗教的发展，实现文明的繁荣
		/// </summary>
		SCIENCE_ACOUSTICS_DESC,
		/// <summary>
		/// 解锁教堂
		/// </summary>
		SCIENCE_ACOUSTICS_EFFECTDESC,
		/// <summary>
		/// 声学
		/// </summary>
		SCIENCE_ACOUSTICS_LABEL,
		/// <summary>
		/// 戏剧和诗歌都是艺术表现形式。推动文化的进步
		/// </summary>
		SCIENCE_DRAMA_DESC,
		/// <summary>
		/// 解锁节日和文化产品
		/// </summary>
		SCIENCE_DRAMA_EFFECTDESC,
		/// <summary>
		/// 戏剧与诗歌
		/// </summary>
		SCIENCE_DRAMA_LABEL,
		/// <summary>
		/// 地质学是研究喵星的岩石组分与地质变迁的科学，可能有利于采矿业的发展
		/// </summary>
		SCIENCE_ARCHEOLOGY_DESC,
		/// <summary>
		/// 解锁采石场和地质学家
		/// </summary>
		SCIENCE_ARCHEOLOGY_EFFECTDESC,
		/// <summary>
		/// 发现了不同种类的巨蜥化石。显然它们都死于一场突如其来却无法逃避的背叛。
		/// </summary>
		SCIENCE_ARCHEOLOGY_FLAVOR,
		/// <summary>
		/// 地质学
		/// </summary>
		SCIENCE_ARCHEOLOGY_LABEL,
		/// <summary>
		/// 电学开拓了自动化生产的新方式，将造福于猫族的各方各面
		/// </summary>
		SCIENCE_ELECTRICITY_DESC,
		/// <summary>
		/// 解锁磁电机
		/// </summary>
		SCIENCE_ELECTRICITY_EFFECTDESC,
		/// <summary>
		/// 谁知道在地毯上跑来跑去竟能产生如此的力量?
		/// </summary>
		SCIENCE_ELECTRICITY_FLAVOR,
		/// <summary>
		/// 电学
		/// </summary>
		SCIENCE_ELECTRICITY_LABEL,
		/// <summary>
		/// 生物学研究各种生物及其特征和在我们社会中的应用。推动科学与化学的发展
		/// </summary>
		SCIENCE_BIOLOGY_DESC,
		/// <summary>
		/// 解锁生物实验室
		/// </summary>
		SCIENCE_BIOLOGY_EFFECTDESC,
		/// <summary>
		/// 生物学
		/// </summary>
		SCIENCE_BIOLOGY_LABEL,
		/// <summary>
		/// 进化的奥秘是时间与死亡
		/// </summary>
		SCIENCE_BIOLOGY_FLAVOR,
		/// <summary>
		/// 促进化学和生物相关科技的发展
		/// </summary>
		SCIENCE_BIOCHEMISTRY_DESC,
		/// <summary>
		/// 解锁生物燃料加工
		/// </summary>
		SCIENCE_BIOCHEMISTRY_EFFECTDESC,
		/// <summary>
		/// 生物化学
		/// </summary>
		SCIENCE_BIOCHEMISTRY_LABEL,
		/// <summary>
		/// 一些分子做的事情
		/// </summary>
		SCIENCE_BIOCHEMISTRY_FLAVOR,
		/// <summary>
		/// 一门能够深远影响生物学和化学的科学。改良食品工业
		/// </summary>
		SCIENCE_GENETICS_DESC,
		/// <summary>
		/// 解锁基因工程(?)
		/// </summary>
		SCIENCE_GENETICS_EFFECTDESC,
		/// <summary>
		/// 遗传学
		/// </summary>
		SCIENCE_GENETICS_LABEL,
		/// <summary>
		/// 有一条从未断绝的线连接着我们与原初之猫。
		/// </summary>
		SCIENCE_GENETICS_FLAVOR,
		/// <summary>
		/// 工业化代表了从食品到机械部件都将大规模生产的概念
		/// </summary>
		SCIENCE_INDUSTRIALIZATION_DESC,
		/// <summary>
		/// 解锁高级自动化和驳船
		/// </summary>
		SCIENCE_INDUSTRIALIZATION_EFFECTDESC,
		/// <summary>
		/// 工业化
		/// </summary>
		SCIENCE_INDUSTRIALIZATION_LABEL,
		/// <summary>
		/// 机械化提供了许多实现冗余任务自动化的方法，从而改进工艺制作、油泵和建筑技术
		/// </summary>
		SCIENCE_MECHANIZATION_DESC,
		/// <summary>
		/// 解锁工厂、抽油机和混凝土
		/// </summary>
		SCIENCE_MECHANIZATION_EFFECTDESC,
		/// <summary>
		/// 机械化
		/// </summary>
		SCIENCE_MECHANIZATION_LABEL,
		/// <summary>
		/// 冶金学改进了金属的生产过程，熔炉和煅烧炉更加高效
		/// </summary>
		SCIENCE_METALURGY_DESC,
		/// <summary>
		/// 解锁电解熔炼和氧化反应
		/// </summary>
		SCIENCE_METALURGY_EFFECTDESC,
		/// <summary>
		/// 冶金学
		/// </summary>
		SCIENCE_METALURGY_LABEL,
		/// <summary>
		/// 燃烧学提供了一些方法，可以用来改进蒸汽工房等基于煤的旧式自动化技术
		/// </summary>
		SCIENCE_COMBUSTION_DESC,
		/// <summary>
		/// 解锁胶印机、炼油厂和燃料喷射器
		/// </summary>
		SCIENCE_COMBUSTION_EFFECTDESC,
		/// <summary>
		/// 燃烧学
		/// </summary>
		SCIENCE_COMBUSTION_LABEL,
		/// <summary>
		/// 生态学是专注于寻找廉价且安全的新型能源的科学
		/// </summary>
		SCIENCE_ECOLOGY_DESC,
		/// <summary>
		/// 解锁太阳能发电站
		/// </summary>
		SCIENCE_ECOLOGY_EFFECTDESC,
		/// <summary>
		/// 生态学
		/// </summary>
		SCIENCE_ECOLOGY_LABEL,
		/// <summary>
		/// 电子学解锁一些主要与科学相关的高级升级
		/// </summary>
		SCIENCE_ELECTRONICS_DESC,
		/// <summary>
		/// 解锁广播塔、CAD 系统、冷藏和搜寻地外文明计划
		/// </summary>
		SCIENCE_ELECTRONICS_EFFECTDESC,
		/// <summary>
		/// 电子学
		/// </summary>
		SCIENCE_ELECTRONICS_LABEL,
		/// <summary>
		/// 机器人学能够改进煅烧炉等自动化结构
		/// </summary>
		SCIENCE_ROBOTICS_DESC,
		/// <summary>
		/// 解锁钢铁工厂、水电站、油轮和回转炉
		/// </summary>
		SCIENCE_ROBOTICS_EFFECTDESC,
		/// <summary>
		/// 机器人学
		/// </summary>
		SCIENCE_ROBOTICS_LABEL,
		/// <summary>
		/// 人工智能是为创造出具有理性并能够执行认知作业的机器而进行的探索
		/// </summary>
		SCIENCE_AI_DESC,
		/// <summary>
		/// 解锁神经网络和 AI 核心
		/// </summary>
		SCIENCE_AI_EFFECTDESC,
		/// <summary>
		/// 人工智能
		/// </summary>
		SCIENCE_AI_LABEL,
		/// <summary>
		/// 核裂变解锁核反应堆及核相关的升级s
		/// </summary>
		SCIENCE_NUCLEARFISSION_DESC,
		/// <summary>
		/// 解锁核反应堆和核动力船
		/// </summary>
		SCIENCE_NUCLEARFISSION_EFFECTDESC,
		/// <summary>
		/// 核裂变
		/// </summary>
		SCIENCE_NUCLEARFISSION_LABEL,
		/// <summary>
		/// 探索太空的基础
		/// </summary>
		SCIENCE_ROCKETRY_DESC,
		/// <summary>
		/// 解锁太空飞船的建造和油气处理
		/// </summary>
		SCIENCE_ROCKETRY_EFFECTDESC,
		/// <summary>
		/// 火箭学
		/// </summary>
		SCIENCE_ROCKETRY_LABEL,
		/// <summary>
		/// 解锁油气处理的高级工艺
		/// </summary>
		SCIENCE_OILPROCESSING_DESC,
		/// <summary>
		/// 解锁煤油和工厂加工
		/// </summary>
		SCIENCE_OILPROCESSING_EFFECTDESC,
		/// <summary>
		/// 油气处理
		/// </summary>
		SCIENCE_OILPROCESSING_LABEL,
		/// <summary>
		/// 卫星是在行星大气层外的轨道上永久运行的装置
		/// </summary>
		SCIENCE_SATTELITES_DESC,
		/// <summary>
		/// 解锁卫星的部署
		/// </summary>
		SCIENCE_SATTELITES_EFFECTDESC,
		/// <summary>
		/// 猫片将以光速传播
		/// </summary>
		SCIENCE_SATTELITES_FLAVOR,
		/// <summary>
		/// 卫星
		/// </summary>
		SCIENCE_SATTELITES_LABEL,
		/// <summary>
		/// 轨道工程使文明能够建设更先进的太空工程
		/// </summary>
		SCIENCE_ORBITALENGINEERING_DESC,
		/// <summary>
		/// 解锁空间站和哈勃天文望远镜
		/// </summary>
		SCIENCE_ORBITALENGINEERING_EFFECTDESC,
		/// <summary>
		/// 轨道工程
		/// </summary>
		SCIENCE_ORBITALENGINEERING_LABEL,
		/// <summary>
		/// 钍是一种具有强放射性和高能效的同位素，可用于太空时代的各种升级
		/// </summary>
		SCIENCE_THORIUM_DESC,
		/// <summary>
		/// 解锁钍反应堆和钍驱动
		/// </summary>
		SCIENCE_THORIUM_EFFECTDESC,
		/// <summary>
		/// 钍
		/// </summary>
		SCIENCE_THORIUM_LABEL,
		/// <summary>
		/// 太空地质学或行星地质学是研究地外金属与矿物的科学
		/// </summary>
		SCIENCE_EXOGEOLOGY_DESC,
		/// <summary>
		/// 解锁各种难得素升级
		/// </summary>
		SCIENCE_EXOGEOLOGY_EFFECTDESC,
		/// <summary>
		/// 太空地质学
		/// </summary>
		SCIENCE_EXOGEOLOGY_LABEL,
		/// <summary>
		/// 高等太空地质学研究加工应用难得素的新工艺
		/// </summary>
		SCIENCE_ADVEXOGEOLOGY_DESC,
		/// <summary>
		/// 解锁E合金和E合金升级
		/// </summary>
		SCIENCE_ADVEXOGEOLOGY_EFFECTDESC,
		/// <summary>
		/// 高等太空地质学
		/// </summary>
		SCIENCE_ADVEXOGEOLOGY_LABEL,
		/// <summary>
		/// 纳米技术是在原子、分子和亚分子尺度上操纵物质的技术。可能被用于改良能源和资源生产
		/// </summary>
		SCIENCE_NANOTECHNOLOGY_DESC,
		/// <summary>
		/// 解锁纳米服、流化反应器、强化和光伏电池
		/// </summary>
		SCIENCE_NANOTECHNOLOGY_EFFECTDESC,
		/// <summary>
		/// 纳米技术
		/// </summary>
		SCIENCE_NANOTECHNOLOGY_LABEL,
		/// <summary>
		/// 超导体是一种神奇的材料，能够大幅提升各种技术的能源效率
		/// </summary>
		SCIENCE_SUPERCONDUCTORS_DESC,
		/// <summary>
		/// 解锁冷聚变和太空制造
		/// </summary>
		SCIENCE_SUPERCONDUCTORS_EFFECTDESC,
		/// <summary>
		/// 超导体
		/// </summary>
		SCIENCE_SUPERCONDUCTORS_LABEL,
		/// <summary>
		/// 反物质提供了先进的能源，广泛推动科学的进步
		/// </summary>
		SCIENCE_ANTIMATTER_DESC,
		/// <summary>
		/// 解锁反物质反应堆、反物质驱动、反物质裂变和反物质基地
		/// </summary>
		SCIENCE_ANTIMATTER_EFFECTDESC,
		/// <summary>
		/// 反物质
		/// </summary>
		SCIENCE_ANTIMATTER_LABEL,
		/// <summary>
		/// 星球改造致力于利用反物质改变喵太阳系中其他行星的气候
		/// </summary>
		SCIENCE_TERRAFORMATION_DESC,
		/// <summary>
		/// 解锁星球改造站
		/// </summary>
		SCIENCE_TERRAFORMATION_EFFECTDESC,
		/// <summary>
		/// 星球改造
		/// </summary>
		SCIENCE_TERRAFORMATION_LABEL,
		/// <summary>
		/// 作为太空工程的巅峰，水栽培为遥远的星际殖民地提供了新的食物来源
		/// </summary>
		SCIENCE_HYDROPONICS_DESC,
		/// <summary>
		/// 解锁纱星的水栽培
		/// </summary>
		SCIENCE_HYDROPONICS_EFFECTDESC,
		/// <summary>
		/// 水栽培
		/// </summary>
		SCIENCE_HYDROPONICS_LABEL,
		/// <summary>
		/// 相较于前身的核物理学，粒子物理学让我们对物质与能量本质的理解更深一步
		/// </summary>
		SCIENCE_PARTICLEPHYSICS_DESC,
		/// <summary>
		/// 解锁粒子加速器、电磁炮和浓缩铀
		/// </summary>
		SCIENCE_PARTICLEPHYSICS_EFFECTDESC,
		/// <summary>
		/// 粒子物理学
		/// </summary>
		SCIENCE_PARTICLEPHYSICS_LABEL,
		/// <summary>
		/// 维物理致力于探索空间与时间的概念
		/// </summary>
		SCIENCE_DIMENSIONALPHYSICS_DESC,
		/// <summary>
		/// 解锁能量裂隙和大型强子对撞机
		/// </summary>
		SCIENCE_DIMENSIONALPHYSICS_EFFECTDESC,
		/// <summary>
		/// 维物理
		/// </summary>
		SCIENCE_DIMENSIONALPHYSICS_LABEL,
		/// <summary>
		/// 时间物理学研究时间的本质和操纵时间的可能性
		/// </summary>
		SCIENCE_CHRONOPHYSICS_DESC,
		/// <summary>
		/// 解锁超时空传送仪、通量冷凝器和静止室
		/// </summary>
		SCIENCE_CHRONOPHYSICS_EFFECTDESC,
		/// <summary>
		/// 时间物理学
		/// </summary>
		SCIENCE_CHRONOPHYSICS_LABEL,
		/// <summary>
		/// 超光速粒子是速度永远超过光速的假想粒子
		/// </summary>
		SCIENCE_TACHYONTHEORY_DESC,
		/// <summary>
		/// 解锁超光速粒子加速器和时间锻造
		/// </summary>
		SCIENCE_TACHYONTHEORY_EFFECTDESC,
		/// <summary>
		/// 超光速粒子理论
		/// </summary>
		SCIENCE_TACHYONTHEORY_LABEL,
		/// <summary>
		/// 奥秘神学应用最神秘晦涩最背离正统的神学理论，以期回答宇宙与现实的根本问题。
		/// </summary>
		SCIENCE_CRYPTOTHEOLOGY_DESC,
		/// <summary>
		/// 解锁遗物站和奥秘神学之树
		/// </summary>
		SCIENCE_CRYPTOTHEOLOGY_EFFECTDESC,
		/// <summary>
		/// 奥秘神学
		/// </summary>
		SCIENCE_CRYPTOTHEOLOGY_LABEL,
		/// <summary>
		/// 虚空之中
		/// </summary>
		SCIENCE_VOIDSPACE_DESC,
		/// <summary>
		/// 解锁冷冻仓
		/// </summary>
		SCIENCE_VOIDSPACE_EFFECTDESC,
		/// <summary>
		/// 虚空领域
		/// </summary>
		SCIENCE_VOIDSPACE_LABEL,
		/// <summary>
		/// TBD
		/// </summary>
		SCIENCE_PARADOXALKNOWLEDGE_DESC,
		/// <summary>
		/// 解锁时间操纵和资源回复
		/// </summary>
		SCIENCE_PARADOXALKNOWLEDGE_EFFECTDESC,
		/// <summary>
		/// 悖论理论
		/// </summary>
		SCIENCE_PARADOXALKNOWLEDGE_LABEL,
		/// <summary>
		/// 隐藏已完成的升级
		/// </summary>
		WORKSHOP_TOGGLERESEARCHED_LABEL,
		/// <summary>
		/// 农民的工作效率提升 50%
		/// </summary>
		WORKSHOP_MINERALHOES_DESC,
		/// <summary>
		/// 矿石锄
		/// </summary>
		WORKSHOP_MINERALHOES_LABEL,
		/// <summary>
		/// 农民的工作效率提升 30%
		/// </summary>
		WORKSHOP_IRONHOES_DESC,
		/// <summary>
		/// 生铁锄
		/// </summary>
		WORKSHOP_IRONHOES_LABEL,
		/// <summary>
		/// 伐木工的工作效率提升 70%
		/// </summary>
		WORKSHOP_MINERALAXES_DESC,
		/// <summary>
		/// 矿石斧
		/// </summary>
		WORKSHOP_MINERALAXES_LABEL,
		/// <summary>
		/// 伐木工的工作效率提升 50%
		/// </summary>
		WORKSHOP_IRONAXES_DESC,
		/// <summary>
		/// 生铁斧
		/// </summary>
		WORKSHOP_IRONAXES_LABEL,
		/// <summary>
		/// 锋利又耐用的斧子。伐木工的工作效率提升 50%
		/// </summary>
		WORKSHOP_STEELAXE_DESC,
		/// <summary>
		/// 精钢斧
		/// </summary>
		WORKSHOP_STEELAXE_LABEL,
		/// <summary>
		/// 木材厂的效率提升 20%
		/// </summary>
		WORKSHOP_REINFORCEDSAW_DESC,
		/// <summary>
		/// 加强锯
		/// </summary>
		WORKSHOP_REINFORCEDSAW_LABEL,
		/// <summary>
		/// 木材厂的效率提升 20%
		/// </summary>
		WORKSHOP_STEELSAW_DESC,
		/// <summary>
		/// 精钢锯
		/// </summary>
		WORKSHOP_STEELSAW_LABEL,
		/// <summary>
		/// 木材厂的效率提升 15%
		/// </summary>
		WORKSHOP_TITANIUMSAW_DESC,
		/// <summary>
		/// 钛金锯
		/// </summary>
		WORKSHOP_TITANIUMSAW_LABEL,
		/// <summary>
		/// 木材厂的效率提升 15%
		/// </summary>
		WORKSHOP_ALLOYSAW_DESC,
		/// <summary>
		/// 合金锯
		/// </summary>
		WORKSHOP_ALLOYSAW_LABEL,
		/// <summary>
		/// 坚不可摧的斧子。伐木工的工作效率提升 50%
		/// </summary>
		WORKSHOP_TITANIUMAXE_DESC,
		/// <summary>
		/// 钛金斧
		/// </summary>
		WORKSHOP_TITANIUMAXE_LABEL,
		/// <summary>
		/// 使用的次数越多，就会变得越锋利!伐木工的工作效率提升 50%
		/// </summary>
		WORKSHOP_ALLOYAXE_DESC,
		/// <summary>
		/// 合金斧
		/// </summary>
		WORKSHOP_ALLOYAXE_LABEL,
		/// <summary>
		/// 这些斧子正如字面上一样难得!伐木工的工作效率提升 50%
		/// </summary>
		WORKSHOP_UNOBTAINIUMAXE_DESC,
		/// <summary>
		/// 难得素斧
		/// </summary>
		WORKSHOP_UNOBTAINIUMAXE_LABEL,
		/// <summary>
		/// 木材厂的效率提升 25%
		/// </summary>
		WORKSHOP_UNOBTAINIUMSAW_DESC,
		/// <summary>
		/// 难得素锯
		/// </summary>
		WORKSHOP_UNOBTAINIUMSAW_LABEL,
		/// <summary>
		/// 木材和铁的存储空间增加 75%
		/// </summary>
		WORKSHOP_STONEBARNS_DESC,
		/// <summary>
		/// 扩容粮仓
		/// </summary>
		WORKSHOP_STONEBARNS_LABEL,
		/// <summary>
		/// 木材和铁的存储空间增加 80%
		/// </summary>
		WORKSHOP_REINFORCEDBARNS_DESC,
		/// <summary>
		/// 加强粮仓
		/// </summary>
		WORKSHOP_REINFORCEDBARNS_LABEL,
		/// <summary>
		/// 存储设施的资源存储量增加 25%
		/// </summary>
		WORKSHOP_REINFORCEDWAREHOUSES_DESC,
		/// <summary>
		/// 加强仓库
		/// </summary>
		WORKSHOP_REINFORCEDWAREHOUSES_LABEL,
		/// <summary>
		/// 存储设施的资源存储量增至 2 倍
		/// </summary>
		WORKSHOP_TITANIUMBARNS_DESC,
		/// <summary>
		/// 钛金粮仓
		/// </summary>
		WORKSHOP_TITANIUMBARNS_LABEL,
		/// <summary>
		/// 存储设施的资源存储量增至 2 倍
		/// </summary>
		WORKSHOP_ALLOYBARNS_DESC,
		/// <summary>
		/// 合金粮仓
		/// </summary>
		WORKSHOP_ALLOYBARNS_LABEL,
		/// <summary>
		/// 存储设施的资源存储量增加 75%
		/// </summary>
		WORKSHOP_CONCRETEBARNS_DESC,
		/// <summary>
		/// 混凝土粮仓
		/// </summary>
		WORKSHOP_CONCRETEBARNS_LABEL,
		/// <summary>
		/// 存储设施的资源存储量增加 50%
		/// </summary>
		WORKSHOP_TITANIUMWAREHOUSES_DESC,
		/// <summary>
		/// 钛金仓库
		/// </summary>
		WORKSHOP_TITANIUMWAREHOUSES_LABEL,
		/// <summary>
		/// 存储设施的资源存储量增加 45%
		/// </summary>
		WORKSHOP_ALLOYWAREHOUSES_DESC,
		/// <summary>
		/// 合金仓库
		/// </summary>
		WORKSHOP_ALLOYWAREHOUSES_LABEL,
		/// <summary>
		/// 存储设施的资源存储量增加 35%
		/// </summary>
		WORKSHOP_CONCRETEWAREHOUSES_DESC,
		/// <summary>
		/// 混凝土仓库
		/// </summary>
		WORKSHOP_CONCRETEWAREHOUSES_LABEL,
		/// <summary>
		/// 存储设施的资源存储量增加 20%
		/// </summary>
		WORKSHOP_STORAGEBUNKERS_DESC,
		/// <summary>
		/// 存储地堡
		/// </summary>
		WORKSHOP_STORAGEBUNKERS_LABEL,
		/// <summary>
		/// 加速器能够创造出口袋次元
		/// </summary>
		WORKSHOP_ENERGYRIFTS_DESC,
		/// <summary>
		/// 能量裂隙
		/// </summary>
		WORKSHOP_ENERGYRIFTS_LABEL,
		/// <summary>
		/// 能量裂隙的存储量增至 2 倍
		/// </summary>
		WORKSHOP_STASISCHAMBERS_DESC,
		/// <summary>
		/// 静止室
		/// </summary>
		WORKSHOP_STASISCHAMBERS_LABEL,
		/// <summary>
		/// 能量裂隙的存储量进一步增加
		/// </summary>
		WORKSHOP_VOIDENERGY_DESC,
		/// <summary>
		/// 虚空能量
		/// </summary>
		WORKSHOP_VOIDENERGY_LABEL,
		/// <summary>
		/// 能量裂隙的存储量增加至 2.5 倍
		/// </summary>
		WORKSHOP_DARKENERGY_DESC,
		/// <summary>
		/// 暗能量
		/// </summary>
		WORKSHOP_DARKENERGY_LABEL,
		/// <summary>
		/// 与时间操纵相关的异星科技
		/// </summary>
		WORKSHOP_CHRONOFORGE_DESC,
		/// <summary>
		/// 时间锻造
		/// </summary>
		WORKSHOP_CHRONOFORGE_LABEL,
		/// <summary>
		/// 能量裂隙的存储量增加至 5 倍
		/// </summary>
		WORKSHOP_TACHYONACCELERATORS_DESC,
		/// <summary>
		/// 超光速粒子加速器
		/// </summary>
		WORKSHOP_TACHYONACCELERATORS_LABEL,
		/// <summary>
		/// 超时空传送仪可以作用于工艺制作资源
		/// </summary>
		WORKSHOP_FLUXCONDENSATOR_DESC,
		/// <summary>
		/// 通量冷凝器
		/// </summary>
		WORKSHOP_FLUXCONDENSATOR_LABEL,
		/// <summary>
		/// 每级加速器都将提升最大科学上限
		/// </summary>
		WORKSHOP_LHC_DESC,
		/// <summary>
		/// 大型强子对撞机
		/// </summary>
		WORKSHOP_LHC_LABEL,
		/// <summary>
		/// 太阳能发电站效能增加 50%
		/// </summary>
		WORKSHOP_PHOTOVOLTAIC_DESC,
		/// <summary>
		/// 光伏电池
		/// </summary>
		WORKSHOP_PHOTOVOLTAIC_LABEL,
		/// <summary>
		/// 卫星将能够产生能源而非消耗能源
		/// </summary>
		WORKSHOP_SOLARSATELLITES_DESC,
		/// <summary>
		/// 太阳能卫星
		/// </summary>
		WORKSHOP_SOLARSATELLITES_LABEL,
		/// <summary>
		/// 每艘船都将使海港的存储量增加 1%
		/// </summary>
		WORKSHOP_CARGOSHIPS_DESC,
		/// <summary>
		/// 就像金枪鱼罐头，不过大得多
		/// </summary>
		WORKSHOP_CARGOSHIPS_FLAVOR,
		/// <summary>
		/// 货轮
		/// </summary>
		WORKSHOP_CARGOSHIPS_LABEL,
		/// <summary>
		/// 港口可以储存更多的煤
		/// </summary>
		WORKSHOP_BARGES_DESC,
		/// <summary>
		/// 驳船
		/// </summary>
		WORKSHOP_BARGES_LABEL,
		/// <summary>
		/// 每级反应堆使货轮的潜能提升 5%
		/// </summary>
		WORKSHOP_REACTORVESSEL_DESC,
		/// <summary>
		/// 反应堆槽
		/// </summary>
		WORKSHOP_REACTORVESSEL_LABEL,
		/// <summary>
		/// 小屋的价格比率降低 50%
		/// </summary>
		WORKSHOP_IRONWOOD_DESC,
		/// <summary>
		/// 铁木小屋
		/// </summary>
		WORKSHOP_IRONWOOD_LABEL,
		/// <summary>
		/// 小屋的价格比率降低 30%
		/// </summary>
		WORKSHOP_CONCRETEHUTS_DESC,
		/// <summary>
		/// 混凝土小屋
		/// </summary>
		WORKSHOP_CONCRETEHUTS_LABEL,
		/// <summary>
		/// 小屋的价格比率降低 25%
		/// </summary>
		WORKSHOP_UNOBTAINIUMHUTS_DESC,
		/// <summary>
		/// 难得素小屋
		/// </summary>
		WORKSHOP_UNOBTAINIUMHUTS_LABEL,
		/// <summary>
		/// 小屋的价格比率降低 10%
		/// </summary>
		WORKSHOP_ELUDIUMHUTS_DESC,
		/// <summary>
		/// E合金小屋
		/// </summary>
		WORKSHOP_ELUDIUMHUTS_LABEL,
		/// <summary>
		/// 仓库现在可以储存猫薄荷
		/// </summary>
		WORKSHOP_SILOS_DESC,
		/// <summary>
		/// 当然也准备了地毯和爬架
		/// </summary>
		WORKSHOP_SILOS_FLAVOR,
		/// <summary>
		/// 筒仓
		/// </summary>
		WORKSHOP_SILOS_LABEL,
		/// <summary>
		/// 猫薄荷的存储量增加 75%
		/// </summary>
		WORKSHOP_REFRIGERATION_DESC,
		/// <summary>
		/// 冷藏
		/// </summary>
		WORKSHOP_REFRIGERATION_LABEL,
		/// <summary>
		/// 改进后的弓，喵力产出获得 +50% 的永久加成
		/// </summary>
		WORKSHOP_COMPOSITEBOW_DESC,
		/// <summary>
		/// 复合弓
		/// </summary>
		WORKSHOP_COMPOSITEBOW_LABEL,
		/// <summary>
		/// 进一步改良的弓，喵力产出获得 +25% 的永久加成
		/// </summary>
		WORKSHOP_CROSSBOW_DESC,
		/// <summary>
		/// 弩
		/// </summary>
		WORKSHOP_CROSSBOW_LABEL,
		/// <summary>
		/// 致命的电磁武器，喵力产出获得 +25% 的加成
		/// </summary>
		WORKSHOP_RAILGUN_DESC,
		/// <summary>
		/// 电磁炮
		/// </summary>
		WORKSHOP_RAILGUN_LABEL,
		/// <summary>
		/// 死吧，鼠辈!
		/// </summary>
		WORKSHOP_RAILGUN_FLAVOR,
		/// <summary>
		/// 用沉重的石块制作的投掷武器。猎人的狩猎效率增至 2 倍
		/// </summary>
		WORKSHOP_BOLAS_DESC,
		/// <summary>
		/// 变成武器的毛线团
		/// </summary>
		WORKSHOP_BOLAS_FLAVOR,
		/// <summary>
		/// 投石索
		/// </summary>
		WORKSHOP_BOLAS_LABEL,
		/// <summary>
		/// 猎人的狩猎效率增加至 3 倍
		/// </summary>
		WORKSHOP_HUNTINGARMOR_DESC,
		/// <summary>
		/// 至少他们穿了东西...
		/// </summary>
		WORKSHOP_HUNTINGARMOR_FLAVOR,
		/// <summary>
		/// 狩猎盔甲
		/// </summary>
		WORKSHOP_HUNTINGARMOR_LABEL,
		/// <summary>
		/// 增加猎人的狩猎效率
		/// </summary>
		WORKSHOP_STEELARMOR_DESC,
		/// <summary>
		/// 精钢甲
		/// </summary>
		WORKSHOP_STEELARMOR_LABEL,
		/// <summary>
		/// 增加猎人的狩猎效率
		/// </summary>
		WORKSHOP_ALLOYARMOR_DESC,
		/// <summary>
		/// 合金甲
		/// </summary>
		WORKSHOP_ALLOYARMOR_LABEL,
		/// <summary>
		/// 喵力全开!
		/// </summary>
		WORKSHOP_NANOSUITS_DESC,
		/// <summary>
		/// 纳米服
		/// </summary>
		WORKSHOP_NANOSUITS_LABEL,
		/// <summary>
		/// 你的交易所对种族地位产生轻微的影响
		/// </summary>
		WORKSHOP_CARAVANSERAI_DESC,
		/// <summary>
		/// 正在招聘:萌死人的小猫
		/// </summary>
		WORKSHOP_CARAVANSERAI_FLAVOR,
		/// <summary>
		/// 商队驿站
		/// </summary>
		WORKSHOP_CARAVANSERAI_LABEL,
		/// <summary>
		/// 猫薄荷精炼效能加倍
		/// </summary>
		WORKSHOP_ADVANCEDREFINEMENT_DESC,
		/// <summary>
		/// 这是所有的乐趣所在，直到有人被抓住
		/// </summary>
		WORKSHOP_ADVANCEDREFINEMENT_FLAVOR,
		/// <summary>
		/// 浓缩猫薄荷
		/// </summary>
		WORKSHOP_ADVANCEDREFINEMENT_LABEL,
		/// <summary>
		/// 少量的矿石将被熔炼成黄金
		/// </summary>
		WORKSHOP_GOLDORE_DESC,
		/// <summary>
		/// 金闪闪!
		/// </summary>
		WORKSHOP_GOLDORE_FLAVOR,
		/// <summary>
		/// 金矿
		/// </summary>
		WORKSHOP_GOLDORE_LABEL,
		/// <summary>
		/// 地质学家效率提升，并且可以开采黄金
		/// </summary>
		WORKSHOP_GEODESY_DESC,
		/// <summary>
		/// 嗅到了黄金的味道喵!
		/// </summary>
		WORKSHOP_GEODESY_FLAVOR,
		/// <summary>
		/// 测地学
		/// </summary>
		WORKSHOP_GEODESY_LABEL,
		/// <summary>
		/// 领导根据经验来分配管理工作
		/// </summary>
		WORKSHOP_REGISTER_DESC,
		/// <summary>
		/// 注册
		/// </summary>
		WORKSHOP_REGISTER_LABEL,
		/// <summary>
		/// 用混凝土修理粮仓和仓库的裂缝
		/// </summary>
		WORKSHOP_STRENGHTENBUILD_DESC,
		/// <summary>
		/// 混凝土支柱
		/// </summary>
		WORKSHOP_STRENGHTENBUILD_LABEL,
		/// <summary>
		/// 地质学家效率提升
		/// </summary>
		WORKSHOP_MININGDRILL_DESC,
		/// <summary>
		/// 采矿钻
		/// </summary>
		WORKSHOP_MININGDRILL_LABEL,
		/// <summary>
		/// 地质学家效率进一步提升
		/// </summary>
		WORKSHOP_UNOBTAINIUMDRILL_DESC,
		/// <summary>
		/// 难得素钻
		/// </summary>
		WORKSHOP_UNOBTAINIUMDRILL_LABEL,
		/// <summary>
		/// 熔炉在燃烧木材时可以产生煤
		/// </summary>
		WORKSHOP_COALFURNACE_DESC,
		/// <summary>
		/// 真暖和... 想打盹...
		/// </summary>
		WORKSHOP_COALFURNACE_FLAVOR,
		/// <summary>
		/// 煤炉
		/// </summary>
		WORKSHOP_COALFURNACE_LABEL,
		/// <summary>
		/// 矿井现在也可以开采煤
		/// </summary>
		WORKSHOP_DEEPMINING_DESC,
		/// <summary>
		/// 美味的金丝雀!
		/// </summary>
		WORKSHOP_DEEPMINING_FLAVOR,
		/// <summary>
		/// 深井开采
		/// </summary>
		WORKSHOP_DEEPMINING_LABEL,
		/// <summary>
		/// 煤的产量增加 20%
		/// </summary>
		WORKSHOP_PYROLYSIS_DESC,
		/// <summary>
		/// 高温分解
		/// </summary>
		WORKSHOP_PYROLYSIS_LABEL,
		/// <summary>
		/// 熔炉的效能增至 2 倍
		/// </summary>
		WORKSHOP_ELECTROLYTICSMELTING_DESC,
		/// <summary>
		/// 电解熔炼
		/// </summary>
		WORKSHOP_ELECTROLYTICSMELTING_LABEL,
		/// <summary>
		/// 煅烧炉的铁生产效率增至 2 倍，钛生产效率增至 4 倍
		/// </summary>
		WORKSHOP_OXIDATION_DESC,
		/// <summary>
		/// 氧化反应
		/// </summary>
		WORKSHOP_OXIDATION_LABEL,
		/// <summary>
		/// 煅烧炉将 10% 的铁产量冶炼为钢
		/// </summary>
		WORKSHOP_STEELPLANTS_DESC,
		/// <summary>
		/// 钢铁工厂
		/// </summary>
		WORKSHOP_STEELPLANTS_LABEL,
		/// <summary>
		/// 钢铁工厂获得工艺制作比率 25% 的加成
		/// </summary>
		WORKSHOP_AUTOMATEDPLANTS_DESC,
		/// <summary>
		/// 自动工厂
		/// </summary>
		WORKSHOP_AUTOMATEDPLANTS_LABEL,
		/// <summary>
		/// 每级反应堆额外为钢铁工厂加成 2%
		/// </summary>
		WORKSHOP_NUCLEARPLANTS_DESC,
		/// <summary>
		/// 核动力工厂
		/// </summary>
		WORKSHOP_NUCLEARPLANTS_LABEL,
		/// <summary>
		/// 煅烧炉的铁生产效率增加 75%，钛生产效率增至 3 倍
		/// </summary>
		WORKSHOP_ROTARYKILN_DESC,
		/// <summary>
		/// 回转炉
		/// </summary>
		WORKSHOP_ROTARYKILN_LABEL,
		/// <summary>
		/// 煅烧炉效率增至 2 倍
		/// </summary>
		WORKSHOP_FLUIDIZEDREACTORS_DESC,
		/// <summary>
		/// 流化反应器
		/// </summary>
		WORKSHOP_FLUIDIZEDREACTORS_LABEL,
		/// <summary>
		/// 熔炉现在可以产生钛
		/// </summary>
		WORKSHOP_NUCLEARSMELTERS_DESC,
		/// <summary>
		/// 核熔炉
		/// </summary>
		WORKSHOP_NUCLEARSMELTERS_LABEL,
		/// <summary>
		/// 蒸汽工房可以自动印刷手稿
		/// </summary>
		WORKSHOP_PRINTINGPRESS_DESC,
		/// <summary>
		/// 印刷机
		/// </summary>
		WORKSHOP_PRINTINGPRESS_LABEL,
		/// <summary>
		/// 印刷机效率增至 4 倍
		/// </summary>
		WORKSHOP_OFFSETPRESS_DESC,
		/// <summary>
		/// 进去白纸，出来猫图
		/// </summary>
		WORKSHOP_OFFSETPRESS_FLAVOR,
		/// <summary>
		/// 胶印机
		/// </summary>
		WORKSHOP_OFFSETPRESS_LABEL,
		/// <summary>
		/// 印刷机效率增至 4 倍
		/// </summary>
		WORKSHOP_PHOTOLITHOGRAPHY_DESC,
		/// <summary>
		/// 光刻机
		/// </summary>
		WORKSHOP_PHOTOLITHOGRAPHY_LABEL,
		/// <summary>
		/// 蒸汽工房每年会运行一次，将达到上限的资源少量制作成工艺资源
		/// </summary>
		WORKSHOP_FACTORYAUTOMATION_DESC,
		/// <summary>
		/// 也包括自动喂食器
		/// </summary>
		WORKSHOP_FACTORYAUTOMATION_FLAVOR,
		/// <summary>
		/// 工坊自动化
		/// </summary>
		WORKSHOP_FACTORYAUTOMATION_LABEL,
		/// <summary>
		/// 工坊自动化每年将运行两次
		/// </summary>
		WORKSHOP_ADVANCEDAUTOMATION_DESC,
		/// <summary>
		/// 高级自动化
		/// </summary>
		WORKSHOP_ADVANCEDAUTOMATION_LABEL,
		/// <summary>
		/// 工坊自动化也会将铁制作成金属板
		/// </summary>
		WORKSHOP_PNEUMATICPRESS_DESC,
		/// <summary>
		/// 气动压力机
		/// </summary>
		WORKSHOP_PNEUMATICPRESS_LABEL,
		/// <summary>
		/// 将蒸汽工房的煤耗降低 20％
		/// </summary>
		WORKSHOP_COMBUSTIONENGINE_DESC,
		/// <summary>
		/// 更好的捕鼠器
		/// </summary>
		WORKSHOP_COMBUSTIONENGINE_FLAVOR,
		/// <summary>
		/// 高压引擎
		/// </summary>
		WORKSHOP_COMBUSTIONENGINE_LABEL,
		/// <summary>
		/// 将蒸汽工房的煤耗降低 20％
		/// </summary>
		WORKSHOP_FUELINJECTORS_DESC,
		/// <summary>
		/// 燃料喷射器
		/// </summary>
		WORKSHOP_FUELINJECTORS_LABEL,
		/// <summary>
		/// 工厂为工艺制作效率提供更多加成
		/// </summary>
		WORKSHOP_FACTORYLOGISTICS_DESC,
		/// <summary>
		/// 工厂物流
		/// </summary>
		WORKSHOP_FACTORYLOGISTICS_LABEL,
		/// <summary>
		/// 提高工程师的工作效率
		/// </summary>
		WORKSHOP_FACTORYOPTIMIZATION_DESC,
		/// <summary>
		/// 工厂优化
		/// </summary>
		WORKSHOP_FACTORYOPTIMIZATION_LABEL,
		/// <summary>
		/// 提高工程师的工作效率
		/// </summary>
		WORKSHOP_FACTORYROBOTICS_DESC,
		/// <summary>
		/// 工业机器人
		/// </summary>
		WORKSHOP_FACTORYROBOTICS_LABEL,
		/// <summary>
		/// 提高工程师的工作效率
		/// </summary>
		WORKSHOP_SPACEENGINEERS_DESC,
		/// <summary>
		/// 空间工程师
		/// </summary>
		WORKSHOP_SPACEENGINEERS_LABEL,
		/// <summary>
		/// 提高工程师的工作效率
		/// </summary>
		WORKSHOP_CHRONOENGINEERS_DESC,
		/// <summary>
		/// 时间工程师
		/// </summary>
		WORKSHOP_CHRONOENGINEERS_LABEL,
		/// <summary>
		/// 工厂为太空电梯和轨道阵列提供加成
		/// </summary>
		WORKSHOP_SPACEMANUFACTURING_DESC,
		/// <summary>
		/// 太空制造
		/// </summary>
		WORKSHOP_SPACEMANUFACTURING_LABEL,
		/// <summary>
		/// 天文事件和流星将产生更多的科学
		/// </summary>
		WORKSHOP_CELESTIALMECHANICS_DESC,
		/// <summary>
		/// 天体力学
		/// </summary>
		WORKSHOP_CELESTIALMECHANICS_LABEL,
		/// <summary>
		/// 天文台的最大科学上限增加 50%
		/// </summary>
		WORKSHOP_ASTROLABE_DESC,
		/// <summary>
		/// 天体观测仪
		/// </summary>
		WORKSHOP_ASTROLABE_LABEL,
		/// <summary>
		/// 天文望远镜的改进型反射镜。每级天文台将使图书馆的效能增加 2%
		/// </summary>
		WORKSHOP_TITANIUMMIRRORS_DESC,
		/// <summary>
		/// 那个光点是不是刚刚动了下?
		/// </summary>
		WORKSHOP_TITANIUMMIRRORS_FLAVOR,
		/// <summary>
		/// 钛金反射镜
		/// </summary>
		WORKSHOP_TITANIUMMIRRORS_LABEL,
		/// <summary>
		/// 天文望远镜的改进型反射镜。每级天文台将使图书馆的效能额外增加 2%
		/// </summary>
		WORKSHOP_UNOBTAINIUMREFLECTORS_DESC,
		/// <summary>
		/// 难得素反射镜
		/// </summary>
		WORKSHOP_UNOBTAINIUMREFLECTORS_LABEL,
		/// <summary>
		/// 天文望远镜的改进型反射镜。每级天文台将使图书馆的效能额外增加 2%
		/// </summary>
		WORKSHOP_ELUDIUMREFLECTORS_DESC,
		/// <summary>
		/// E合金反射镜
		/// </summary>
		WORKSHOP_ELUDIUMREFLECTORS_LABEL,
		/// <summary>
		/// 应用难得素制作的涡轮机。水电站能源输出提高 15％
		/// </summary>
		WORKSHOP_HYDROPLANTTURBINES_DESC,
		/// <summary>
		/// 水电涡轮机
		/// </summary>
		WORKSHOP_HYDROPLANTTURBINES_LABEL,
		/// <summary>
		/// 月球基地的能源消耗降低 50％
		/// </summary>
		WORKSHOP_AMBASES_DESC,
		/// <summary>
		/// 反物质基地
		/// </summary>
		WORKSHOP_AMBASES_LABEL,
		/// <summary>
		/// 人工智能驱动的后勤管理。每级工作中的 AI 核心将使月球基地的资源存储量增加 10%
		/// </summary>
		WORKSHOP_AIBASES_DESC,
		/// <summary>
		/// AI基地
		/// </summary>
		WORKSHOP_AIBASES_LABEL,
		/// <summary>
		/// 由反物质驱动的火箭发动机
		/// </summary>
		WORKSHOP_AMDRIVE_DESC,
		/// <summary>
		/// 反物质驱动
		/// </summary>
		WORKSHOP_AMDRIVE_LABEL,
		/// <summary>
		/// 工程师生产E合金的效率增加 25%
		/// </summary>
		WORKSHOP_AMFISSION_DESC,
		/// <summary>
		/// 反物质裂变
		/// </summary>
		WORKSHOP_AMFISSION_LABEL,
		/// <summary>
		/// 科研船和太空灯塔的效能增加 95%
		/// </summary>
		WORKSHOP_AMREACTORS_DESC,
		/// <summary>
		/// 反物质反应堆
		/// </summary>
		WORKSHOP_AMREACTORS_LABEL,
		/// <summary>
		/// 科研船和太空灯塔的效能进一步增加 ~77%
		/// </summary>
		WORKSHOP_AMREACTORSMK2_DESC,
		/// <summary>
		/// 高级反物质反应堆
		/// </summary>
		WORKSHOP_AMREACTORSMK2_LABEL,
		/// <summary>
		/// 科研船和太空灯塔的效能进一步增加 ~116%
		/// </summary>
		WORKSHOP_VOIDREACTORS_DESC,
		/// <summary>
		/// 虚空反应堆
		/// </summary>
		WORKSHOP_VOIDREACTORS_LABEL,
		/// <summary>
		/// 太空灯塔升级为遗物研究站。通过对遗物进行逆向工程，每级遗物站单日产出 0.01 遗物
		/// </summary>
		WORKSHOP_RELICSTATION_DESC,
		/// <summary>
		/// 遗物站
		/// </summary>
		WORKSHOP_RELICSTATION_LABEL,
		/// <summary>
		/// 油井的效率提升 45％，每级油井将消耗 1W 电力
		/// </summary>
		WORKSHOP_PUMPJACK_DESC,
		/// <summary>
		/// 抽油机
		/// </summary>
		WORKSHOP_PUMPJACK_LABEL,
		/// <summary>
		/// 生物实验室将猫薄荷转化为石油
		/// </summary>
		WORKSHOP_BIOFUEL_DESC,
		/// <summary>
		/// 生物燃料加工
		/// </summary>
		WORKSHOP_BIOFUEL_LABEL,
		/// <summary>
		/// 独角兽牧场的效能提高升 25％
		/// </summary>
		WORKSHOP_UNICORNSELECTION_DESC,
		/// <summary>
		/// 独角兽选种
		/// </summary>
		WORKSHOP_UNICORNSELECTION_LABEL,
		/// <summary>
		/// 转基因猫薄荷将生物实验室的石油产量提升 60%
		/// </summary>
		WORKSHOP_GMO_DESC,
		/// <summary>
		/// 转基因猫薄荷
		/// </summary>
		WORKSHOP_GMO_LABEL,
		/// <summary>
		/// 所有科学建筑都将提升蓝图制作的效率
		/// </summary>
		WORKSHOP_CADSYSTEMS_DESC,
		/// <summary>
		/// CAD 系统
		/// </summary>
		WORKSHOP_CADSYSTEMS_LABEL,
		/// <summary>
		/// 大量的电子望远镜。天文事件观测将自动静默进行
		/// </summary>
		WORKSHOP_SETI_DESC,
		/// <summary>
		/// 搜寻地外文明计划
		/// </summary>
		WORKSHOP_SETI_LABEL,
		/// <summary>
		/// 小猫的技能效率将提升 15%
		/// </summary>
		WORKSHOP_LOGISTICS_DESC,
		/// <summary>
		/// 后勤
		/// </summary>
		WORKSHOP_LOGISTICS_LABEL,
		/// <summary>
		/// 小猫的技能效率将提升 100%
		/// </summary>
		WORKSHOP_AUGUMENTATION_DESC,
		/// <summary>
		/// 强化
		/// </summary>
		WORKSHOP_AUGUMENTATION_LABEL,
		/// <summary>
		/// 小猫彼此学习技能
		/// </summary>
		WORKSHOP_INTERNET_DESC,
		/// <summary>
		/// 猫国电信
		/// </summary>
		WORKSHOP_INTERNET_LABEL,
		/// <summary>
		/// 工程师的效率加倍。小猫能够从猫类圈中学习
		/// </summary>
		WORKSHOP_NEURALNETWORKS_DESC,
		/// <summary>
		/// 神经网络
		/// </summary>
		WORKSHOP_NEURALNETWORKS_LABEL,
		/// <summary>
		/// 最为先进的人工智能
		/// </summary>
		WORKSHOP_AI_DESC,
		/// <summary>
		/// AI
		/// </summary>
		WORKSHOP_AI_LABEL,
		/// <summary>
		/// 工业机器人使重复的工作自动化。工作的小猫需要的猫薄荷减少了
		/// </summary>
		WORKSHOP_ASSISTANCE_DESC,
		/// <summary>
		/// 机器人协助
		/// </summary>
		WORKSHOP_ASSISTANCE_LABEL,
		/// <summary>
		/// 反应堆的铀消耗量减少 25%
		/// </summary>
		WORKSHOP_ENRICHEDURANIUM_DESC,
		/// <summary>
		/// 浓缩铀
		/// </summary>
		WORKSHOP_ENRICHEDURANIUM_LABEL,
		/// <summary>
		/// 反应堆的能源输出提升 25%
		/// </summary>
		WORKSHOP_COLDFUSION_DESC,
		/// <summary>
		/// 冷聚变
		/// </summary>
		WORKSHOP_COLDFUSION_LABEL,
		/// <summary>
		/// 通过添加钍使反应堆的能源输出增加 25％
		/// </summary>
		WORKSHOP_THORIUMREACTORS_DESC,
		/// <summary>
		/// 钍反应堆
		/// </summary>
		WORKSHOP_THORIUMREACTORS_LABEL,
		/// <summary>
		/// 反应堆的钍消耗量减少 25%
		/// </summary>
		WORKSHOP_ENRICHEDTHORIUM_DESC,
		/// <summary>
		/// 浓缩钍
		/// </summary>
		WORKSHOP_ENRICHEDTHORIUM_LABEL,
		/// <summary>
		/// 星图产出增加 30%
		/// </summary>
		WORKSHOP_HUBBLETELESCOPE_DESC,
		/// <summary>
		/// 哈勃天文望远镜
		/// </summary>
		WORKSHOP_HUBBLETELESCOPE_LABEL,
		/// <summary>
		/// 每级卫星使造船需要的星图减少 1.25%
		/// </summary>
		WORKSHOP_SATNAV_DESC,
		/// <summary>
		/// 卫星导航
		/// </summary>
		WORKSHOP_SATNAV_LABEL,
		/// <summary>
		/// 每颗卫星都会将广播塔的效能提升 0.5％
		/// </summary>
		WORKSHOP_SATELLITERADIO_DESC,
		/// <summary>
		/// 卫星电台
		/// </summary>
		WORKSHOP_SATELLITERADIO_LABEL,
		/// <summary>
		/// 每个学者都会生成星图
		/// </summary>
		WORKSHOP_ASTROPHYSICISTS_DESC,
		/// <summary>
		/// 天体物理学家
		/// </summary>
		WORKSHOP_ASTROPHYSICISTS_LABEL,
		/// <summary>
		/// 月球前哨中应用了E合金的新型反应装置。难得素生产效率提升 75％
		/// </summary>
		WORKSHOP_MWREACTOR_DESC,
		/// <summary>
		/// 微型亚空间反应装置
		/// </summary>
		WORKSHOP_MWREACTOR_LABEL,
		/// <summary>
		/// 喵村号的输出效率提升一倍
		/// </summary>
		WORKSHOP_ELUDIUMCRACKER_DESC,
		/// <summary>
		/// 星球毁灭
		/// </summary>
		WORKSHOP_ELUDIUMCRACKER_LABEL,
		/// <summary>
		/// 新型火箭发动机，能够在太空中更快地飞行
		/// </summary>
		WORKSHOP_THORIUMENGINE_DESC,
		/// <summary>
		/// 钍驱动
		/// </summary>
		WORKSHOP_THORIUMENGINE_LABEL,
		/// <summary>
		/// 油井的效能提高 35%
		/// </summary>
		WORKSHOP_OILREFINERY_DESC,
		/// <summary>
		/// 炼油厂
		/// </summary>
		WORKSHOP_OILREFINERY_LABEL,
		/// <summary>
		/// 石油产量增加 75%.
		/// </summary>
		WORKSHOP_OILDISTILLATION_DESC,
		/// <summary>
		/// 油蒸馏
		/// </summary>
		WORKSHOP_OILDISTILLATION_LABEL,
		/// <summary>
		/// 每级工厂都会将炼油效率提高 5％
		/// </summary>
		WORKSHOP_FACTORYPROCESSING_DESC,
		/// <summary>
		/// 工厂加工
		/// </summary>
		WORKSHOP_FACTORYPROCESSING_LABEL,
		/// <summary>
		/// 解锁虚空抽取和虚空裂隙
		/// </summary>
		WORKSHOP_VOIDASPIRATION_DESC,
		/// <summary>
		/// 虚空吸取
		/// </summary>
		WORKSHOP_VOIDASPIRATION_LABEL,
		/// <summary>
		/// 提高时间操纵的效能
		/// </summary>
		WORKSHOP_DISTORSION_DESC,
		/// <summary>
		/// 时空扭曲
		/// </summary>
		WORKSHOP_DISTORSION_LABEL,
		/// <summary>
		/// 超时空传送仪将产生时间通量
		/// </summary>
		WORKSHOP_TURNSMOOTHLY_DESC,
		/// <summary>
		/// 时间波动
		/// </summary>
		WORKSHOP_TURNSMOOTHLY_LABEL,
		/// <summary>
		/// 坚固的猫薄荷木块。加工起来很麻烦，却是很好的建筑材料
		/// </summary>
		WORKSHOP_CRAFTS_WOOD_DESC,
		/// <summary>
		/// 精炼猫薄荷
		/// </summary>
		WORKSHOP_CRAFTS_WOOD_LABEL,
		/// <summary>
		/// 简单的木质支撑结构，是建造高级建筑的基础
		/// </summary>
		WORKSHOP_CRAFTS_BEAM_DESC,
		/// <summary>
		/// 木梁
		/// </summary>
		WORKSHOP_CRAFTS_BEAM_LABEL,
		/// <summary>
		/// 由矿物组成的石板，是建造高级建筑的基础
		/// </summary>
		WORKSHOP_CRAFTS_SLAB_DESC,
		/// <summary>
		/// 石板
		/// </summary>
		WORKSHOP_CRAFTS_SLAB_LABEL,
		/// <summary>
		/// 一块钢筋混凝土
		/// </summary>
		WORKSHOP_CRAFTS_CONCRATE_DESC,
		/// <summary>
		/// 混凝土
		/// </summary>
		WORKSHOP_CRAFTS_CONCRATE_LABEL,
		/// <summary>
		/// 一块金属板，是建造高级建筑的基础
		/// </summary>
		WORKSHOP_CRAFTS_PLATE_DESC,
		/// <summary>
		/// 金属板
		/// </summary>
		WORKSHOP_CRAFTS_PLATE_LABEL,
		/// <summary>
		/// 用铁和煤冶炼得到的坚实金属，用于制作齿轮和复杂的机械
		/// </summary>
		WORKSHOP_CRAFTS_STEEL_DESC,
		/// <summary>
		/// 钢
		/// </summary>
		WORKSHOP_CRAFTS_STEEL_LABEL,
		/// <summary>
		/// 自动化结构中不可或缺的组成部分
		/// </summary>
		WORKSHOP_CRAFTS_GEAR_DESC,
		/// <summary>
		/// 齿轮
		/// </summary>
		WORKSHOP_CRAFTS_GEAR_LABEL,
		/// <summary>
		/// 钢铁和钛制成的坚实合金，用于建造高级建筑和工坊升级
		/// </summary>
		WORKSHOP_CRAFTS_ALLOY_DESC,
		/// <summary>
		/// 合金
		/// </summary>
		WORKSHOP_CRAFTS_ALLOY_LABEL,
		/// <summary>
		/// 难得素与钛制成的极为罕见珍贵的合金
		/// </summary>
		WORKSHOP_CRAFTS_ELUDIUM_DESC,
		/// <summary>
		/// E合金
		/// </summary>
		WORKSHOP_CRAFTS_ELUDIUM_LABEL,
		/// <summary>
		/// 木梁制作的大型结构，用于建造非常复杂的建筑和东西
		/// </summary>
		WORKSHOP_CRAFTS_SCAFFOLD_DESC,
		/// <summary>
		/// 脚手架
		/// </summary>
		WORKSHOP_CRAFTS_SCAFFOLD_LABEL,
		/// <summary>
		/// 船可以用于发现新的文明。可能增加获得某些罕见资源的机会
		/// </summary>
		WORKSHOP_CRAFTS_SHIP_DESC,
		/// <summary>
		/// 贸易船
		/// </summary>
		WORKSHOP_CRAFTS_SHIP_LABEL,
		/// <summary>
		/// 将石油的存储上限提高 500 点
		/// </summary>
		WORKSHOP_CRAFTS_TANKER_DESC,
		/// <summary>
		/// 油轮
		/// </summary>
		WORKSHOP_CRAFTS_TANKER_LABEL,
		/// <summary>
		/// 加工石油得到的火箭燃料
		/// </summary>
		WORKSHOP_CRAFTS_KEROSENE_DESC,
		/// <summary>
		/// 煤油
		/// </summary>
		WORKSHOP_CRAFTS_KEROSENE_LABEL,
		/// <summary>
		/// 使用动物毛皮制作的用于书写的材料，是文化建筑的基础
		/// </summary>
		WORKSHOP_CRAFTS_PARCHMENT_DESC,
		/// <summary>
		/// 羊皮纸
		/// </summary>
		WORKSHOP_CRAFTS_PARCHMENT_LABEL,
		/// <summary>
		/// 科技发展所需的书面文件。每份手稿会轻微增加最大文化上限(这一效果的增益递减)
		/// </summary>
		WORKSHOP_CRAFTS_MANUSCRIPT_DESC,
		/// <summary>
		/// 手稿
		/// </summary>
		WORKSHOP_CRAFTS_MANUSCRIPT_LABEL,
		/// <summary>
		/// 猫类所有现代知识的总和。每份概要会使最大科学上限 +10(这一效果无法超过建筑的最大科学上限)
		/// </summary>
		WORKSHOP_CRAFTS_COMPEDIUM_DESC,
		/// <summary>
		/// 概要
		/// </summary>
		WORKSHOP_CRAFTS_COMPEDIUM_LABEL,
		/// <summary>
		/// 有着蓝色线条的奇怪的纸
		/// </summary>
		WORKSHOP_CRAFTS_BLUEPRINT_DESC,
		/// <summary>
		/// 蓝图
		/// </summary>
		WORKSHOP_CRAFTS_BLUEPRINT_LABEL,
		/// <summary>
		/// 具有高放射性且不稳定的燃料
		/// </summary>
		WORKSHOP_CRAFTS_THORIUM_DESC,
		/// <summary>
		/// 钍
		/// </summary>
		WORKSHOP_CRAFTS_THORIUM_LABEL,
		/// <summary>
		/// 用于建造巨型结构的大石块
		/// </summary>
		WORKSHOP_CRAFTS_MEGALITH_DESC,
		/// <summary>
		/// 巨石
		/// </summary>
		WORKSHOP_CRAFTS_MEGALITH_LABEL,
		/// <summary>
		/// 工程师的最适等级
		/// </summary>
		WORKSHOP_CRAFTBTN_DESC_TIER,
		/// <summary>
		/// 工程师专有技能
		/// </summary>
		WORKSHOP_CRAFTBTN_DESC_CRAFTRATIO,
		/// <summary>
		/// 工艺制作难度
		/// </summary>
		WORKSHOP_CRAFTBTN_DESC_PROGRESSHANDICAP,
		/// <summary>
		/// 每 {0} 秒制作一次
		/// </summary>
		WORKSHOP_CRAFTBTN_DESC_COUNTDOWN,
		/// <summary>
		/// 升级
		/// </summary>
		WORKSHOP_UPGRADEPANEL_LABEL,
		/// <summary>
		/// 工艺制作
		/// </summary>
		WORKSHOP_CRAFTPANEL_LABEL,
		/// <summary>
		/// 空闲工程师
		/// </summary>
		WORKSHOP_CRAFTPANEL_HEADER_FREEENGINEERS,
		/// <summary>
		/// 每级工厂提供一个工程师岗位。\n工程师被分配岗位后会自动进行工艺制作
		/// </summary>
		WORKSHOP_CRAFTPANEL_HEADER_TOOLTIP,
		/// <summary>
		/// 材料
		/// </summary>
		WORKSHOP_CRAFTPANEL_COUNTS_LABEL,
		/// <summary>
		/// {0} {1} 已返还
		/// </summary>
		WORKSHOP_UNDO_MSG,
		/// <summary>
		/// +{0} {1} 已制作
		/// </summary>
		WORKSHOP_CRAFTED_MSG,
		/// <summary>
		/// 所有升级均已解锁!
		/// </summary>
		WORKSHOP_ALL_UPGRADES_UNLOCKED,
		/// <summary>
		/// 工艺制作效率: +{0}%
		/// </summary>
		WORKSHOP_CRAFT_EFFECTIVENESS,
		/// <summary>
		/// 复制到剪贴板: Ctrl+C, Enter
		/// </summary>
		GENERAL_COPY_TO_CLIPBOARD_PROMPT,
		/// <summary>
		/// 食品顾问:你的猫薄荷储量过低!
		/// </summary>
		GENERAL_FOOD_ADVISOR_TEXT,
		/// <summary>
		/// 猫薄荷
		/// </summary>
		RESOURCES_CATNIP_TITLE,
		/// <summary>
		/// 木材
		/// </summary>
		RESOURCES_WOOD_TITLE,
		/// <summary>
		/// 矿物
		/// </summary>
		RESOURCES_MINERALS_TITLE,
		/// <summary>
		/// 煤
		/// </summary>
		RESOURCES_COAL_TITLE,
		/// <summary>
		/// 铁
		/// </summary>
		RESOURCES_IRON_TITLE,
		/// <summary>
		/// 钛
		/// </summary>
		RESOURCES_TITANIUM_TITLE,
		/// <summary>
		/// 黄金
		/// </summary>
		RESOURCES_GOLD_TITLE,
		/// <summary>
		/// 石油
		/// </summary>
		RESOURCES_OIL_TITLE,
		/// <summary>
		/// 铀
		/// </summary>
		RESOURCES_URANIUM_TITLE,
		/// <summary>
		/// 难得素
		/// </summary>
		RESOURCES_UNOBTAINIUM_TITLE,
		/// <summary>
		/// 喵力
		/// </summary>
		RESOURCES_MANPOWER_TITLE,
		/// <summary>
		/// 科学
		/// </summary>
		RESOURCES_SCIENCE_TITLE,
		/// <summary>
		/// 文化
		/// </summary>
		RESOURCES_CULTURE_TITLE,
		/// <summary>
		/// 信仰
		/// </summary>
		RESOURCES_FAITH_TITLE,
		/// <summary>
		/// 猫口
		/// </summary>
		RESOURCES_KITTENS_TITLE,
		/// <summary>
		/// 斑马
		/// </summary>
		RESOURCES_ZEBRAS_TITLE,
		/// <summary>
		/// 星图
		/// </summary>
		RESOURCES_STARCHART_TITLE,
		/// <summary>
		/// 反物质
		/// </summary>
		RESOURCES_ANTIMATTER_TITLE,
		/// <summary>
		/// 毛皮
		/// </summary>
		RESOURCES_FURS_TITLE,
		/// <summary>
		/// 象牙
		/// </summary>
		RESOURCES_IVORY_TITLE,
		/// <summary>
		/// 香料
		/// </summary>
		RESOURCES_SPICE_TITLE,
		/// <summary>
		/// 独角兽
		/// </summary>
		RESOURCES_UNICORNS_TITLE,
		/// <summary>
		/// 天角兽
		/// </summary>
		RESOURCES_ALICORN_TITLE,
		/// <summary>
		/// 死灵兽
		/// </summary>
		RESOURCES_NECROCORN_TITLE,
		/// <summary>
		/// 眼泪
		/// </summary>
		RESOURCES_TEARS_TITLE,
		/// <summary>
		/// 业
		/// </summary>
		RESOURCES_KARMA_TITLE,
		/// <summary>
		/// 领导力
		/// </summary>
		RESOURCES_PARAGON_TITLE,
		/// <summary>
		/// 燃烧领导力
		/// </summary>
		RESOURCES_BURNEDPARAGON_TITLE,
		/// <summary>
		/// 时间水晶
		/// </summary>
		RESOURCES_TIMECRYSTAL_TITLE,
		/// <summary>
		/// 悲伤
		/// </summary>
		RESOURCES_SORROW_TITLE,
		/// <summary>
		/// 遗物
		/// </summary>
		RESOURCES_RELIC_TITLE,
		/// <summary>
		/// 虚空
		/// </summary>
		RESOURCES_VOID_TITLE,
		/// <summary>
		/// 礼品盒
		/// </summary>
		RESOURCES_ELDERBOX_TITLE,
		/// <summary>
		/// 古诞节快乐!
		/// </summary>
		RESOURCES_ELDERBOX_DESC,
		/// <summary>
		/// 包装纸
		/// </summary>
		RESOURCES_WRAPPINGPAPER_TITLE,
		/// <summary>
		/// 时间通量
		/// </summary>
		RESOURCES_TEMPORALFLUX_TITLE,
		/// <summary>
		/// 木梁
		/// </summary>
		RESOURCES_BEAM_TITLE,
		/// <summary>
		/// 石板
		/// </summary>
		RESOURCES_SLAB_TITLE,
		/// <summary>
		/// 混凝土
		/// </summary>
		RESOURCES_CONCRATE_TITLE,
		/// <summary>
		/// 金属板
		/// </summary>
		RESOURCES_PLATE_TITLE,
		/// <summary>
		/// 钢
		/// </summary>
		RESOURCES_STEEL_TITLE,
		/// <summary>
		/// 齿轮
		/// </summary>
		RESOURCES_GEAR_TITLE,
		/// <summary>
		/// 合金
		/// </summary>
		RESOURCES_ALLOY_TITLE,
		/// <summary>
		/// E合金
		/// </summary>
		RESOURCES_ELUDIUM_TITLE,
		/// <summary>
		/// 脚手架
		/// </summary>
		RESOURCES_SCAFFOLD_TITLE,
		/// <summary>
		/// 船
		/// </summary>
		RESOURCES_SHIP_TITLE,
		/// <summary>
		/// 油轮
		/// </summary>
		RESOURCES_TANKER_TITLE,
		/// <summary>
		/// 煤油
		/// </summary>
		RESOURCES_KEROSENE_TITLE,
		/// <summary>
		/// 羊皮纸
		/// </summary>
		RESOURCES_PARCHMENT_TITLE,
		/// <summary>
		/// 手稿
		/// </summary>
		RESOURCES_MANUSCRIPT_TITLE,
		/// <summary>
		/// 概要
		/// </summary>
		RESOURCES_COMPEDIUM_TITLE,
		/// <summary>
		/// 蓝图
		/// </summary>
		RESOURCES_BLUEPRINT_TITLE,
		/// <summary>
		/// 钍
		/// </summary>
		RESOURCES_THORIUM_TITLE,
		/// <summary>
		/// 巨石
		/// </summary>
		RESOURCES_MEGALITH_TITLE,
		/// <summary>
		/// 全部
		/// </summary>
		RESOURCES_CRAFTTABLE_ALL,
		/// <summary>
		/// 上限 {0}
		/// </summary>
		EFFECTSMGR_TYPE_RESMAX,
		/// <summary>
		/// {0} 加成
		/// </summary>
		EFFECTSMGR_TYPE_RESRATIO,
		/// <summary>
		/// {0} 需求减少
		/// </summary>
		EFFECTSMGR_TYPE_RESDEMANDRATIO,
		/// <summary>
		/// {0} 产出
		/// </summary>
		EFFECTSMGR_TYPE_RESPRODUCTION,
		/// <summary>
		/// {0} 转换
		/// </summary>
		EFFECTSMGR_TYPE_RESCONVERSION,
		/// <summary>
		/// {0} 工艺制作效率
		/// </summary>
		EFFECTSMGR_TYPE_RESCRAFTRATIO,
		/// <summary>
		/// 农民工具
		/// </summary>
		EFFECTSMGR_STATICS_CATNIPJOBRATIO_TITLE,
		/// <summary>
		/// 工作的小猫 猫薄荷需求减少
		/// </summary>
		EFFECTSMGR_STATICS_CATNIPDEMANDWORKERRATIOGLOBAL_TITLE,
		/// <summary>
		/// 伐木工工具
		/// </summary>
		EFFECTSMGR_STATICS_WOODJOBRATIO_TITLE,
		/// <summary>
		/// 猎人工具
		/// </summary>
		EFFECTSMGR_STATICS_MANPOWERJOBRATIO_TITLE,
		/// <summary>
		/// 煤产量惩罚
		/// </summary>
		EFFECTSMGR_STATICS_COALRATIOGLOBAL_TITLE,
		/// <summary>
		/// 煤产量惩罚降低
		/// </summary>
		EFFECTSMGR_STATICS_COALRATIOGLOBALREDUCTION_TITLE,
		/// <summary>
		/// 石油消耗减少
		/// </summary>
		EFFECTSMGR_STATICS_OILREDUCTIONRATIO_TITLE,
		/// <summary>
		/// 小猫
		/// </summary>
		EFFECTSMGR_STATICS_MAXKITTENS_TITLE,
		/// <summary>
		/// 反物质产出
		/// </summary>
		EFFECTSMGR_STATICS_ANTIMATTERPRODUCTION_TITLE,
		/// <summary>
		/// 时间通量产出
		/// </summary>
		EFFECTSMGR_STATICS_TEMPORALFLUXPRODUCTION_TITLE,
		/// <summary>
		/// 传送仪时间通量产出
		/// </summary>
		EFFECTSMGR_STATICS_TEMPORALFLUXPRODUCTIONCHRONOSPHERE_TITLE,
		/// <summary>
		/// 天文台科学比率
		/// </summary>
		EFFECTSMGR_STATICS_OBSERVATORYRATIO_TITLE,
		/// <summary>
		/// 磁电机增幅
		/// </summary>
		EFFECTSMGR_STATICS_MAGNETOBOOSTRATIO_TITLE,
		/// <summary>
		/// 技能学习
		/// </summary>
		EFFECTSMGR_STATICS_SKILLXP_TITLE,
		/// <summary>
		/// 猫薄荷精炼加成
		/// </summary>
		EFFECTSMGR_STATICS_REFINERATIO_TITLE,
		/// <summary>
		/// 工艺制作加成
		/// </summary>
		EFFECTSMGR_STATICS_CRAFTRATIO_TITLE,
		/// <summary>
		/// 幸福度
		/// </summary>
		EFFECTSMGR_STATICS_HAPPINESS_TITLE,
		/// <summary>
		/// 不幸福度减少
		/// </summary>
		EFFECTSMGR_STATICS_UNHAPPINESSRATIO_TITLE,
		/// <summary>
		/// 贸易比率
		/// </summary>
		EFFECTSMGR_STATICS_TRADERATIO_TITLE,
		/// <summary>
		/// 种族地位比率
		/// </summary>
		EFFECTSMGR_STATICS_STANDINGRATIO_TITLE,
		/// <summary>
		/// 资源保留比率
		/// </summary>
		EFFECTSMGR_STATICS_RESSTASISRATIO_TITLE,
		/// <summary>
		/// 灯塔遗物产出
		/// </summary>
		EFFECTSMGR_STATICS_BEACONRELICSPERDAY_TITLE,
		/// <summary>
		/// 遗物产出
		/// </summary>
		EFFECTSMGR_STATICS_RELICPERDAY_TITLE,
		/// <summary>
		/// 太空飞行速度
		/// </summary>
		EFFECTSMGR_STATICS_ROUTESPEED_TITLE,
		/// <summary>
		/// 能源产出
		/// </summary>
		EFFECTSMGR_STATICS_ENERGYPRODUCTION_TITLE,
		/// <summary>
		/// 能源消耗
		/// </summary>
		EFFECTSMGR_STATICS_ENERGYCONSUMPTION_TITLE,
		/// <summary>
		/// 能源产出加成
		/// </summary>
		EFFECTSMGR_STATICS_ENERGYPRODUCTIONRATIO_TITLE,
		/// <summary>
		/// 生产加成
		/// </summary>
		EFFECTSMGR_STATICS_PRODUCTIONRATIO_TITLE,
		/// <summary>
		/// 生产加成
		/// </summary>
		EFFECTSMGR_STATICS_MAGNETORATIO_TITLE,
		/// <summary>
		/// 空间生产加成
		/// </summary>
		EFFECTSMGR_STATICS_SPACERATIO_TITLE,
		/// <summary>
		/// 地面生产加成转移
		/// </summary>
		EFFECTSMGR_STATICS_PRODTRANSFERBONUS_TITLE,
		/// <summary>
		/// 天文事件概率
		/// </summary>
		EFFECTSMGR_STATICS_STAREVENTCHANCE_TITLE,
		/// <summary>
		/// 自动天文事件概率
		/// </summary>
		EFFECTSMGR_STATICS_STARAUTOSUCCESSCHANCE_TITLE,
		/// <summary>
		/// 木材厂加成
		/// </summary>
		EFFECTSMGR_STATICS_LUMBERMILLRATIO_TITLE,
		/// <summary>
		/// 粮仓扩容
		/// </summary>
		EFFECTSMGR_STATICS_BARNRATIO_TITLE,
		/// <summary>
		/// 仓库扩容
		/// </summary>
		EFFECTSMGR_STATICS_WAREHOUSERATIO_TITLE,
		/// <summary>
		/// 加速器扩容
		/// </summary>
		EFFECTSMGR_STATICS_ACCELERATORRATIO_TITLE,
		/// <summary>
		/// 港口船扩容
		/// </summary>
		EFFECTSMGR_STATICS_HARBORRATIO_TITLE,
		/// <summary>
		/// 港口煤存储量扩容
		/// </summary>
		EFFECTSMGR_STATICS_HARBORCOALRATIO_TITLE,
		/// <summary>
		/// 猫薄荷存储量扩容
		/// </summary>
		EFFECTSMGR_STATICS_CATNIPMAXRATIO_TITLE,
		/// <summary>
		/// 狩猎效率
		/// </summary>
		EFFECTSMGR_STATICS_HUNTERRATIO_TITLE,
		/// <summary>
		/// 太阳能发电站加成
		/// </summary>
		EFFECTSMGR_STATICS_SOLARFARMRATIO_TITLE,
		/// <summary>
		/// 船上限
		/// </summary>
		EFFECTSMGR_STATICS_SHIPLIMIT_TITLE,
		/// <summary>
		/// 小屋价格比率降低
		/// </summary>
		EFFECTSMGR_STATICS_HUTPRICERATIO_TITLE,
		/// <summary>
		/// 煤加成
		/// </summary>
		EFFECTSMGR_STATICS_COALSUPERRATIO_TITLE,
		/// <summary>
		/// 熔炉加成
		/// </summary>
		EFFECTSMGR_STATICS_SMELTERRATIO_TITLE,
		/// <summary>
		/// 煅烧炉加成
		/// </summary>
		EFFECTSMGR_STATICS_CALCINERRATIO_TITLE,
		/// <summary>
		/// 煅烧炉钢产量
		/// </summary>
		EFFECTSMGR_STATICS_CALCINERSTEELRATIO_TITLE,
		/// <summary>
		/// 钢铁工厂的煅烧炉增益
		/// </summary>
		EFFECTSMGR_STATICS_CALCINERSTEELCRAFTRATIO_TITLE,
		/// <summary>
		/// 煅烧炉钢产量加成
		/// </summary>
		EFFECTSMGR_STATICS_CALCINERSTEELREACTORBONUS_TITLE,
		/// <summary>
		/// 图书馆加成
		/// </summary>
		EFFECTSMGR_STATICS_LIBRARYRATIO_TITLE,
		/// <summary>
		/// 水电站加成
		/// </summary>
		EFFECTSMGR_STATICS_HYDROPLANTRATIO_TITLE,
		/// <summary>
		/// 空间科学加成
		/// </summary>
		EFFECTSMGR_STATICS_SPACESCIENCERATIO_TITLE,
		/// <summary>
		/// 石油加成
		/// </summary>
		EFFECTSMGR_STATICS_OILWELLRATIO_TITLE,
		/// <summary>
		/// 独角兽加成
		/// </summary>
		EFFECTSMGR_STATICS_UNICORNSGLOBALRATIO_TITLE,
		/// <summary>
		/// 生物燃料增益
		/// </summary>
		EFFECTSMGR_STATICS_BIOFUELRATIO_TITLE,
		/// <summary>
		/// 蓝图制作加成
		/// </summary>
		EFFECTSMGR_STATICS_CADBLUEPRINTCRAFTRATIO_TITLE,
		/// <summary>
		/// 小猫技能效果
		/// </summary>
		EFFECTSMGR_STATICS_SKILLMULTIPLIER_TITLE,
		/// <summary>
		/// 铀节省
		/// </summary>
		EFFECTSMGR_STATICS_URANIUMRATIO_TITLE,
		/// <summary>
		/// 反应堆能源加成
		/// </summary>
		EFFECTSMGR_STATICS_REACTORENERGYRATIO_TITLE,
		/// <summary>
		/// 反应堆钍消耗
		/// </summary>
		EFFECTSMGR_STATICS_REACTORTHORIUMPERTICK_TITLE,
		/// <summary>
		/// 星图加成
		/// </summary>
		EFFECTSMGR_STATICS_STARCHARTGLOBALRATIO_TITLE,
		/// <summary>
		/// 造船成本降低
		/// </summary>
		EFFECTSMGR_STATICS_SATNAVRATIO_TITLE,
		/// <summary>
		/// 广播塔增益
		/// </summary>
		EFFECTSMGR_STATICS_BROADCASTTOWERRATIO_TITLE,
		/// <summary>
		/// 文化上限加成
		/// </summary>
		EFFECTSMGR_STATICS_CULTUREMAXRATIO_TITLE,
		/// <summary>
		/// 月球前哨加成
		/// </summary>
		EFFECTSMGR_STATICS_LUNAROUTPOSTRATIO_TITLE,
		/// <summary>
		/// 星球裂解加成
		/// </summary>
		EFFECTSMGR_STATICS_CRACKERRATIO_TITLE,
		/// <summary>
		/// 工厂炼油加成
		/// </summary>
		EFFECTSMGR_STATICS_FACTORYREFINERATIO_TITLE,
		/// <summary>
		/// 时间科技加成
		/// </summary>
		EFFECTSMGR_STATICS_TIMERATIO_TITLE,
		/// <summary>
		/// 虚空产出上限
		/// </summary>
		EFFECTSMGR_STATICS_TEMPORALPARADOXVOID_TITLE,
		/// <summary>
		/// 时间悖论天数
		/// </summary>
		EFFECTSMGR_STATICS_TEMPORALPARADOXDAY_TITLE,
		/// <summary>
		/// 时间悖论天数
		/// </summary>
		EFFECTSMGR_STATICS_TEMPORALPARADOXDAYBONUS_TITLE,
		/// <summary>
		/// 独角兽加成
		/// </summary>
		EFFECTSMGR_STATICS_UNICORNSRATIORELIGION_TITLE,
		/// <summary>
		/// 独角兽裂隙概率
		/// </summary>
		EFFECTSMGR_STATICS_RIFTCHANCE_TITLE,
		/// <summary>
		/// 象牙流星概率
		/// </summary>
		EFFECTSMGR_STATICS_IVORYMETEORCHANCE_TITLE,
		/// <summary>
		/// 象牙流星加成
		/// </summary>
		EFFECTSMGR_STATICS_IVORYMETEORRATIO_TITLE,
		/// <summary>
		/// 黄金上限加成
		/// </summary>
		EFFECTSMGR_STATICS_GOLDMAXRATIO_TITLE,
		/// <summary>
		/// 天角兽降临概率
		/// </summary>
		EFFECTSMGR_STATICS_ALICORNCHANCE_TITLE,
		/// <summary>
		/// 天角兽献祭加成
		/// </summary>
		EFFECTSMGR_STATICS_TCREFINERATIO_TITLE,
		/// <summary>
		/// 腐化速率
		/// </summary>
		EFFECTSMGR_STATICS_CORRUPTIONRATIO_TITLE,
		/// <summary>
		/// 庙塔文化上限加成
		/// </summary>
		EFFECTSMGR_STATICS_CULTUREMAXRATIOBONUS_TITLE,
		/// <summary>
		/// 信仰加成
		/// </summary>
		EFFECTSMGR_STATICS_FAITHRATIORELIGION_TITLE,
		/// <summary>
		/// 遗物精炼加成
		/// </summary>
		EFFECTSMGR_STATICS_RELICREFINERATIO_TITLE,
		/// <summary>
		/// 悲伤上限
		/// </summary>
		EFFECTSMGR_STATICS_BLSLIMIT_TITLE,
		/// <summary>
		/// 资源上限加成
		/// </summary>
		EFFECTSMGR_STATICS_GLOBALRESOURCERATIO_TITLE,
		/// <summary>
		/// 时间惩罚延迟
		/// </summary>
		EFFECTSMGR_STATICS_TIMEIMPEDANCE_TITLE,
		/// <summary>
		/// 资源回复
		/// </summary>
		EFFECTSMGR_STATICS_SHATTERTCGAIN_TITLE,
		/// <summary>
		/// 资源回复效能加成
		/// </summary>
		EFFECTSMGR_STATICS_RRRATIO_TITLE,
		/// <summary>
		/// 建筑价格
		/// </summary>
		EFFECTSMGR_STATICS_PRICERATIO_TITLE,
		/// <summary>
		/// 小猫出生速率
		/// </summary>
		EFFECTSMGR_STATICS_KITTENGROWTHRATIO_TITLE,
		/// <summary>
		/// 1级工程师专有技能
		/// </summary>
		EFFECTSMGR_STATICS_T1CRAFTRATIO_TITLE,
		/// <summary>
		/// 2级工程师专有技能
		/// </summary>
		EFFECTSMGR_STATICS_T2CRAFTRATIO_TITLE,
		/// <summary>
		/// 3级工程师专有技能
		/// </summary>
		EFFECTSMGR_STATICS_T3CRAFTRATIO_TITLE,
		/// <summary>
		/// 4级工程师专有技能
		/// </summary>
		EFFECTSMGR_STATICS_T4CRAFTRATIO_TITLE,
		/// <summary>
		/// 5级工程师专有技能
		/// </summary>
		EFFECTSMGR_STATICS_T5CRAFTRATIO_TITLE,
		/// <summary>
		/// 太空电梯 - 转移生产加成
		/// </summary>
		EFFECTSMGR_STATICS_SPACEELEVATOR_PRODTRANSFERBONUS_TITLE,
		/// <summary>
		/// 卫星 - 星图产出
		/// </summary>
		EFFECTSMGR_STATICS_SATTELITE_STARCHARTPERTICKBASESPACE_TITLE,
		/// <summary>
		/// 卫星 - 天文台科学比率
		/// </summary>
		EFFECTSMGR_STATICS_SATTELITE_OBSERVATORYRATIO_TITLE,
		/// <summary>
		/// 空间站 - 科学加成
		/// </summary>
		EFFECTSMGR_STATICS_SPACESTATION_SCIENCERATIO_TITLE,
		/// <summary>
		/// 月球前哨 - 难得素转化
		/// </summary>
		EFFECTSMGR_STATICS_MOONOUTPOST_UNOBTAINIUMPERTICKSPACE_TITLE,
		/// <summary>
		/// 星球裂解 - 铀转化
		/// </summary>
		EFFECTSMGR_STATICS_PLANETCRACKER_URANIUMPERTICKSPACE_TITLE,
		/// <summary>
		/// 流体切割 - 石油转化
		/// </summary>
		EFFECTSMGR_STATICS_HYDROFRACTURER_OILPERTICKAUTOPRODSPACE_TITLE,
		/// <summary>
		/// 科研船 - 星图产出
		/// </summary>
		EFFECTSMGR_STATICS_RESEARCHVESSEL_STARCHARTPERTICKBASESPACE_TITLE,
		/// <summary>
		/// 太阳提取 - 能源产出
		/// </summary>
		EFFECTSMGR_STATICS_SUNLIFTER_ENERGYPRODUCTION_TITLE,
		/// <summary>
		/// 低温储存站 - 木材上限
		/// </summary>
		EFFECTSMGR_STATICS_CRYOSTATION_WOODMAX_TITLE,
		/// <summary>
		/// 低温储存站 - 矿物上限
		/// </summary>
		EFFECTSMGR_STATICS_CRYOSTATION_MINERALSMAX_TITLE,
		/// <summary>
		/// 低温储存站 - 铁上限
		/// </summary>
		EFFECTSMGR_STATICS_CRYOSTATION_IRONMAX_TITLE,
		/// <summary>
		/// 低温储存站 - 煤上限
		/// </summary>
		EFFECTSMGR_STATICS_CRYOSTATION_COALMAX_TITLE,
		/// <summary>
		/// 低温储存站 - 铀上限
		/// </summary>
		EFFECTSMGR_STATICS_CRYOSTATION_URANIUMMAX_TITLE,
		/// <summary>
		/// 低温储存站 - 钛上限
		/// </summary>
		EFFECTSMGR_STATICS_CRYOSTATION_TITANIUMMAX_TITLE,
		/// <summary>
		/// 低温储存站 - 石油上限
		/// </summary>
		EFFECTSMGR_STATICS_CRYOSTATION_OILMAX_TITLE,
		/// <summary>
		/// 低温储存站 - 难得素上限
		/// </summary>
		EFFECTSMGR_STATICS_CRYOSTATION_UNOBTAINIUMMAX_TITLE,
		/// <summary>
		/// 太空灯塔 - 星图产出
		/// </summary>
		EFFECTSMGR_STATICS_SPACEBEACON_STARCHARTPERTICKBASESPACE_TITLE,
		/// <summary>
		/// 水栽培 - 猫薄荷加成
		/// </summary>
		EFFECTSMGR_STATICS_HYDROPONICS_CATNIPRATIO_TITLE,
		/// <summary>
		/// HR收割机 - 能源产出
		/// </summary>
		EFFECTSMGR_STATICS_HRHARVESTER_ENERGYPRODUCTION_TITLE,
		/// <summary>
		/// 纠缠站 - GFlops 转化
		/// </summary>
		EFFECTSMGR_STATICS_ENTANGLER_GFLOPSCONSUMPTION_TITLE,
		/// <summary>
		/// 香料提取 - 香料产出
		/// </summary>
		EFFECTSMGR_STATICS_SPICEREFINERY_SPICEPERTICKAUTOPRODSPACE_TITLE,
		/// <summary>
		/// 独角兽产量增加 5%
		/// </summary>
		RELIGION_ZU_UNICORNTOMB_DESC,
		/// <summary>
		/// 独角兽坟墓
		/// </summary>
		RELIGION_ZU_UNICORNTOMB_LABEL,
		/// <summary>
		/// 独角兽产量增加 10%，解锁独角兽裂隙
		/// </summary>
		RELIGION_ZU_IVORYTOWER_DESC,
		/// <summary>
		/// 象牙塔
		/// </summary>
		RELIGION_ZU_IVORYTOWER_LABEL,
		/// <summary>
		/// 独角兽产量增加 25%，召唤象牙流星
		/// </summary>
		RELIGION_ZU_IVORYCITADEL_DESC,
		/// <summary>
		/// 象牙城堡
		/// </summary>
		RELIGION_ZU_IVORYCITADEL_LABEL,
		/// <summary>
		/// 独角兽产量增加 50%.传说很久很久以前曾经有一个古老而神秘的种族居住在这里。每级天空宫殿将黄金总量上限提高 1%
		/// </summary>
		RELIGION_ZU_SKYPALACE_DESC,
		/// <summary>
		/// 天空宫殿
		/// </summary>
		RELIGION_ZU_SKYPALACE_LABEL,
		/// <summary>
		/// 独角兽产量增加 250%，增加召唤天角兽的概率，水晶精炼产率增加 5%
		/// </summary>
		RELIGION_ZU_UNICORNUTOPIA_DESC,
		/// <summary>
		/// 独角兽理想国
		/// </summary>
		RELIGION_ZU_UNICORNUTOPIA_LABEL,
		/// <summary>
		/// 独角兽产量增加 500%，大幅增加召唤天角兽的概率，水晶精炼产率增加 10%
		/// </summary>
		RELIGION_ZU_SUNSPIRE_DESC,
		/// <summary>
		/// 太阳尖顶
		/// </summary>
		RELIGION_ZU_SUNSPIRE_LABEL,
		/// <summary>
		/// 以未知金属制成的诡异构造，用途不明
		/// </summary>
		RELIGION_ZU_MARKER_DESC,
		/// <summary>
		/// 神印
		/// </summary>
		RELIGION_ZU_MARKER_LABEL,
		/// <summary>
		/// 萤火虫之墓
		/// </summary>
		RELIGION_ZU_UNICORNGRAVEYARD_DESC,
		/// <summary>
		/// 独角兽墓园
		/// </summary>
		RELIGION_ZU_UNICORNGRAVEYARD_LABEL,
		/// <summary>
		/// 路的尽头是汪洋血海
		/// </summary>
		RELIGION_ZU_UNICORNNECROPOLIS_DESC,
		/// <summary>
		/// 独角兽大墓地
		/// </summary>
		RELIGION_ZU_UNICORNNECROPOLIS_LABEL,
		/// <summary>
		/// 其恐怖不可名状的黑暗遗物
		/// </summary>
		RELIGION_ZU_BLACKPYRAMID_DESC,
		/// <summary>
		/// 黑金字塔
		/// </summary>
		RELIGION_ZU_BLACKPYRAMID_LABEL,
		/// <summary>
		/// 我们都做了什么?!
		/// </summary>
		RELIGION_ZU_BLACKPYRAMID_FLAVOR,
		/// <summary>
		/// 信仰产出增加 10%
		/// </summary>
		RELIGION_RU_SOLARCHANT_DESC,
		/// <summary>
		/// 阳光赞歌
		/// </summary>
		RELIGION_RU_SOLARCHANT_LABEL,
		/// <summary>
		/// 神殿提升最大科学上限
		/// </summary>
		RELIGION_RU_SCHOLASTICISM_DESC,
		/// <summary>
		/// 经院哲学
		/// </summary>
		RELIGION_RU_SCHOLASTICISM_LABEL,
		/// <summary>
		/// 神殿的信仰存储上限提升 50%
		/// </summary>
		RELIGION_RU_GOLDENSPIRE_DESC,
		/// <summary>
		/// 黄金塔尖
		/// </summary>
		RELIGION_RU_GOLDENSPIRE_LABEL,
		/// <summary>
		/// 奢华的尖塔
		/// </summary>
		RELIGION_RU_GOLDENSPIRE_FLAVOR,
		/// <summary>
		/// 小幅提升神殿的信仰存储上限，每级神殿使幸福度提升 0.5%
		/// </summary>
		RELIGION_RU_SUNALTAR_DESC,
		/// <summary>
		/// 太阳祭坛
		/// </summary>
		RELIGION_RU_SUNALTAR_LABEL,
		/// <summary>
		/// 神殿产出的文化增至 2 倍
		/// </summary>
		RELIGION_RU_STAINEDGLASS_DESC,
		/// <summary>
		/// 彩色玻璃
		/// </summary>
		RELIGION_RU_STAINEDGLASS_LABEL,
		/// <summary>
		/// 信仰的积累将轻微推动资源生产
		/// </summary>
		RELIGION_RU_SOLARREVOLUTION_DESC,
		/// <summary>
		/// 太阳革命
		/// </summary>
		RELIGION_RU_SOLARREVOLUTION_LABEL,
		/// <summary>
		/// 神殿产出更多的文化，并提升文化存储上限
		/// </summary>
		RELIGION_RU_BASILICA_DESC,
		/// <summary>
		/// 大教堂
		/// </summary>
		RELIGION_RU_BASILICA_LABEL,
		/// <summary>
		/// 神殿少量提升喵力上限
		/// </summary>
		RELIGION_RU_TEMPLARS_DESC,
		/// <summary>
		/// 圣殿骑士
		/// </summary>
		RELIGION_RU_TEMPLARS_LABEL,
		/// <summary>
		/// 赋予舍弃已经积累的信仰从而提升祈祷效能的能力
		/// </summary>
		RELIGION_RU_APOCRIPHA_DESC,
		/// <summary>
		/// 新约外传
		/// </summary>
		RELIGION_RU_APOCRIPHA_LABEL,
		/// <summary>
		/// 解锁额外的宗教升级
		/// </summary>
		RELIGION_RU_TRANSCENDENCE_DESC,
		/// <summary>
		/// 超越
		/// </summary>
		RELIGION_RU_TRANSCENDENCE_LABEL,
		/// <summary>
		/// 提高信仰加成的上限。\n每级黑方尖碑都会通过每个超越等级使信仰加成的上限提高 5％
		/// </summary>
		RELIGION_TU_BLACKOBELISK_DESC,
		/// <summary>
		/// 黑方尖碑
		/// </summary>
		RELIGION_TU_BLACKOBELISK_LABEL,
		/// <summary>
		/// TBD
		/// </summary>
		RELIGION_TU_BLACKOBELISK_FLAVOR,
		/// <summary>
		/// 提高时间水晶精炼为遗物的产率。\n每级黑之连结都会通过黑金字塔的等级提高遗物的精炼产率。\n这项加成同样提升遗物站的效率
		/// </summary>
		RELIGION_TU_BLACKNEXUS_DESC,
		/// <summary>
		/// 黑之连结
		/// </summary>
		RELIGION_TU_BLACKNEXUS_LABEL,
		/// <summary>
		/// 天空中的眼睛
		/// </summary>
		RELIGION_TU_BLACKNEXUS_FLAVOR,
		/// <summary>
		/// 小规模扭曲现实的规律。\n每级黑之核心使悲伤上限提高 1％
		/// </summary>
		RELIGION_TU_BLACKCORE_DESC,
		/// <summary>
		/// 黑之核心
		/// </summary>
		RELIGION_TU_BLACKCORE_LABEL,
		/// <summary>
		/// 以活祭之猫的骸骨建造
		/// </summary>
		RELIGION_TU_BLACKCORE_FLAVOR,
		/// <summary>
		/// 全局资源存储上限提升 10%
		/// </summary>
		RELIGION_TU_SINGULARITY_DESC,
		/// <summary>
		/// 黑洞视界
		/// </summary>
		RELIGION_TU_SINGULARITY_LABEL,
		/// <summary>
		/// 一个入口……通往什么?
		/// </summary>
		RELIGION_TU_SINGULARITY_FLAVOR,
		/// <summary>
		/// 提升时间相关构造
		/// </summary>
		RELIGION_TU_BLAZAR_DESC,
		/// <summary>
		/// 耀变体
		/// </summary>
		RELIGION_TU_BLAZAR_LABEL,
		/// <summary>
		/// 老虎!老虎!光焰闪耀
		/// </summary>
		RELIGION_TU_BLAZAR_FLAVOR,
		/// <summary>
		/// 全局能源产出提高 2%
		/// </summary>
		RELIGION_TU_DARKNOVA_DESC,
		/// <summary>
		/// 黑暗新星
		/// </summary>
		RELIGION_TU_DARKNOVA_LABEL,
		/// <summary>
		/// 那颗星已经死了，就像我们的希望和梦想。
		/// </summary>
		RELIGION_TU_DARKNOVA_FLAVOR,
		/// <summary>
		/// 眼泪再也无法落下
		/// </summary>
		RELIGION_TU_HOLYGENOCIDE_DESC,
		/// <summary>
		/// 神圣灭绝
		/// </summary>
		RELIGION_TU_HOLYGENOCIDE_LABEL,
		/// <summary>
		/// 我们居住在黑暗的无限之海中一座名为无知的平静小岛，而这并不意味着我们应该远航。
		/// </summary>
		RELIGION_TU_HOLYGENOCIDE_FLAVOR,
		/// <summary>
		/// 你的天角兽被神印腐化了!
		/// </summary>
		RELIGION_MSG_CORRUPTION,
		/// <summary>
		/// 庙塔
		/// </summary>
		RELIGION_PANEL_ZIGGURAT_LABEL,
		/// <summary>
		/// 太阳教团
		/// </summary>
		RELIGION_PANEL_ORDEROFTHESUN_LABEL,
		/// <summary>
		/// 奥秘神学
		/// </summary>
		RELIGION_PANEL_CRYPTOTHEOLOGY_LABEL,
		/// <summary>
		/// 献祭独角兽
		/// </summary>
		RELIGION_SACRIFICEBTN_LABEL,
		/// <summary>
		/// 使独角兽回归独角兽的维度。每级庙塔会收到一滴独角兽眼泪
		/// </summary>
		RELIGION_SACRIFICEBTN_DESC,
		/// <summary>
		/// 全部
		/// </summary>
		RELIGION_SACRIFICEBTN_ALL,
		/// <summary>
		/// {0} 只独角兽被献祭。你获得了 {1} 滴独角兽眼泪!
		/// </summary>
		RELIGION_SACRIFICEBTN_SACRIFICE_MSG,
		/// <summary>
		/// 献祭天角兽
		/// </summary>
		RELIGION_SACRIFICEALICORNSBTN_LABEL,
		/// <summary>
		/// 将天角兽放逐到鲜血之月。得到一颗时间水晶
		/// </summary>
		RELIGION_SACRIFICEALICORNSBTN_DESC,
		/// <summary>
		/// {0} 只天角兽被放逐了，你获得了 {1} 颗时间水晶!
		/// </summary>
		RELIGION_SACRIFICEALICORNSBTN_SACRIFICE_MSG,
		/// <summary>
		/// 提炼眼泪
		/// </summary>
		RELIGION_REFINETEARSBTN_LABEL,
		/// <summary>
		/// 将独角兽眼泪提炼为黑色液体悲伤
		/// </summary>
		RELIGION_REFINETEARSBTN_DESC,
		/// <summary>
		/// 什么都没发生
		/// </summary>
		RELIGION_REFINETEARSBTN_REFINE_MSG_FAILURE,
		/// <summary>
		/// 精炼时间水晶
		/// </summary>
		RELIGION_REFINETCSBTN_LABEL,
		/// <summary>
		/// 将时间水晶精炼为上古遗物
		/// </summary>
		RELIGION_REFINETCSBTN_DESC,
		/// <summary>
		/// 精炼时间水晶得到了 {0} 份遗物
		/// </summary>
		RELIGION_REFINETCSBTN_REFINE_MSG,
		/// <summary>
		/// [重置信仰池]
		/// </summary>
		RELIGION_FAITHRESETBTN_LABEL,
		/// <summary>
		/// 赞美太阳!
		/// </summary>
		RELIGION_PRAISEBTN_LABEL,
		/// <summary>
		/// 将积累的信仰转换进入信仰总量
		/// </summary>
		RELIGION_PRAISEBTN_DESC,
		/// <summary>
		/// 次元超越
		/// </summary>
		RELIGION_TRANSCENDBTN_LABEL,
		/// <summary>
		/// 除非超越猫类的极限
		/// </summary>
		RELIGION_TRANSCENDBTN_DESC,
		/// <summary>
		/// 信仰总量: {0}
		/// </summary>
		RELIGION_FAITHCOUNT_POOL,
		/// <summary>
		/// 信仰加成
		/// </summary>
		RELIGION_FAITHCOUNT_BONUS,
		/// <summary>
		/// 你积累了 +{0} 信仰
		/// </summary>
		RELIGION_PRAISE_MSG,
		/// <summary>
		/// 确定要重置信仰池吗?\n\n通过赞美太阳积累的信仰池将会转化为赞美太阳加成。\n\n此加成将会在游戏重置时保留。\n\n点击此按钮将清空已经积累的信仰池。
		/// </summary>
		RELIGION_RESETFAITH_CONFIRMATION_MSG,
		/// <summary>
		/// 确定要舍弃赞美太阳加成吗?\n\n通过牺牲一部分赞美太阳加成将可以提升到新的超越等级。\n每个超越等级都将提升信仰重置的效率。\n每次提升超越等级都需要牺牲更多的信仰加成。\n\n此加成可以累积并在游戏重置时保留。\n\n点击此按钮将移除一部分赞美太阳加成。
		/// </summary>
		RELIGION_TRANSCEND_CONFIRMATION_MSG,
		/// <summary>
		/// 要进行次元超越吗?
		/// </summary>
		RELIGION_TRANSCEND_CONFIRMATION_TITLE,
		/// <summary>
		/// 超越了猫类的极限。达到超越等级: {0}
		/// </summary>
		RELIGION_TRANSCEND_MSG_SUCCESS,
		/// <summary>
		/// 更近一步: {0} ({1}%)
		/// </summary>
		RELIGION_TRANSCEND_MSG_FAILURE,
		/// <summary>
		/// 上古遗产
		/// </summary>
		ACHIEVEMENTS_THEELDERLEGACY_TITLE,
		/// <summary>
		/// 成为第一批测试猫国建设者手机版的玩家
		/// </summary>
		ACHIEVEMENTS_THEELDERLEGACY_DESC,
		/// <summary>
		/// 独角兽的阴谋
		/// </summary>
		ACHIEVEMENTS_UNICORNCONSPIRACY_TITLE,
		/// <summary>
		/// 揭开独角兽阴谋的伪装!
		/// </summary>
		ACHIEVEMENTS_UNICORNCONSPIRACY_DESC,
		/// <summary>
		/// 这不是在做梦
		/// </summary>
		ACHIEVEMENTS_UNICEPTION_TITLE,
		/// <summary>
		/// 发现阴谋中的阴谋
		/// </summary>
		ACHIEVEMENTS_UNICEPTION_DESC,
		/// <summary>
		/// 太阳帝国的原罪
		/// </summary>
		ACHIEVEMENTS_SINSOFEMPIRE_TITLE,
		/// <summary>
		/// 等等, 你是认真的?
		/// </summary>
		ACHIEVEMENTS_SINSOFEMPIRE_DESC,
		/// <summary>
		/// 星际之门
		/// </summary>
		ACHIEVEMENTS_ANACHRONOX_TITLE,
		/// <summary>
		/// 请止步
		/// </summary>
		ACHIEVEMENTS_ANACHRONOX_DESC,
		/// <summary>
		/// 死亡空间
		/// </summary>
		ACHIEVEMENTS_DEADSPACE_TITLE,
		/// <summary>
		/// 你喵喵喵啊，再喵也没人能听到的!
		/// </summary>
		ACHIEVEMENTS_DEADSPACE_DESC,
		/// <summary>
		/// 钢铁意志
		/// </summary>
		ACHIEVEMENTS_IRONWILL_TITLE,
		/// <summary>
		/// 你配的上这个称号
		/// </summary>
		ACHIEVEMENTS_IRONWILL_DESC,
		/// <summary>
		/// 魅力小猫
		/// </summary>
		ACHIEVEMENTS_UBERKATZHEN_TITLE,
		/// <summary>
		/// 没能杀死你的将使你变得更强大
		/// </summary>
		ACHIEVEMENTS_UBERKATZHEN_DESC,
		/// <summary>
		/// 百年孤独
		/// </summary>
		ACHIEVEMENTS_HUNDREDYEARSSOLITUDE_TITLE,
		/// <summary>
		/// 太远是多远?
		/// </summary>
		ACHIEVEMENTS_HUNDREDYEARSSOLITUDE_DESC,
		/// <summary>
		/// 新垦地
		/// </summary>
		ACHIEVEMENTS_SOILUPTUNED_TITLE,
		/// <summary>
		/// 在钢铁意志下建造 45 级牧场
		/// </summary>
		ACHIEVEMENTS_SOILUPTUNED_DESC,
		/// <summary>
		/// 未喵的阿特拉斯
		/// </summary>
		ACHIEVEMENTS_ATLASUNMEOWED_TITLE,
		/// <summary>
		/// 在钢铁意志下建造磁电机
		/// </summary>
		ACHIEVEMENTS_ATLASUNMEOWED_DESC,
		/// <summary>
		/// 喵喵革命
		/// </summary>
		ACHIEVEMENTS_MEOWMEOWREVOLUTION_TITLE,
		/// <summary>
		/// 在钢铁意志下建造工厂
		/// </summary>
		ACHIEVEMENTS_MEOWMEOWREVOLUTION_DESC,
		/// <summary>
		/// 太空怪人
		/// </summary>
		ACHIEVEMENTS_SPACEODDITY_TITLE,
		/// <summary>
		/// 在钢铁意志下完成登月计划
		/// </summary>
		ACHIEVEMENTS_SPACEODDITY_DESC,
		/// <summary>
		/// 在钢铁意志下不依靠领导力完成登月
		/// </summary>
		ACHIEVEMENTS_SPACEODDITY_STARDESC,
		/// <summary>
		/// 木升战纪
		/// </summary>
		ACHIEVEMENTS_JUPITERASCENDING_TITLE,
		/// <summary>
		/// 在第一年到达太空
		/// </summary>
		ACHIEVEMENTS_JUPITERASCENDING_DESC,
		/// <summary>
		/// 巨像阴影
		/// </summary>
		ACHIEVEMENTS_SHADOWOFTHECOLOSSUS_TITLE,
		/// <summary>
		/// 只有一只小猫就建造了庙塔
		/// </summary>
		ACHIEVEMENTS_SHADOWOFTHECOLOSSUS_DESC,
		/// <summary>
		/// 太阳神
		/// </summary>
		ACHIEVEMENTS_SUNGOD_TITLE,
		/// <summary>
		/// 累计积累 696,342 信仰
		/// </summary>
		ACHIEVEMENTS_SUNGOD_DESC,
		/// <summary>
		/// 黑暗之心
		/// </summary>
		ACHIEVEMENTS_HEARTOFDARKNESS_TITLE,
		/// <summary>
		/// 成为斑马部落的酋长。(怎么可能做的到(╯°口°)╯(┴—┴
		/// </summary>
		ACHIEVEMENTS_HEARTOFDARKNESS_DESC,
		/// <summary>
		/// 冬天来了
		/// </summary>
		ACHIEVEMENTS_WINTERISCOMING_TITLE,
		/// <summary>
		/// 死了 10 只喵星人
		/// </summary>
		ACHIEVEMENTS_WINTERISCOMING_DESC,
		/// <summary>
		/// 你这个禽兽
		/// </summary>
		ACHIEVEMENTS_YOUMONSTER_TITLE,
		/// <summary>
		/// 可怜的小猫们
		/// </summary>
		ACHIEVEMENTS_YOUMONSTER_DESC,
		/// <summary>
		/// 不道德的巅峰
		/// </summary>
		ACHIEVEMENTS_SUPERUNETHICALCLIMAX_TITLE,
		/// <summary>
		/// 通过作弊玩游戏
		/// </summary>
		ACHIEVEMENTS_SUPERUNETHICALCLIMAX_DESC,
		/// <summary>
		/// 莲台侵蚀机
		/// </summary>
		ACHIEVEMENTS_LOTUSMACHINE_TITLE,
		/// <summary>
		/// 打破轮回的循环，积累业的数量大于 1
		/// </summary>
		ACHIEVEMENTS_LOTUSMACHINE_DESC,
		/// <summary>
		/// 宁静
		/// </summary>
		ACHIEVEMENTS_SERENITY_TITLE,
		/// <summary>
		/// 没有失去任何一只小猫的状态下猫口达到 50
		/// </summary>
		ACHIEVEMENTS_SERENITY_DESC,
		/// <summary>
		/// 乌托邦计划
		/// </summary>
		ACHIEVEMENTS_UTOPIAPROJECT_TITLE,
		/// <summary>
		/// 总幸福度超过 150%
		/// </summary>
		ACHIEVEMENTS_UTOPIAPROJECT_DESC,
		/// <summary>
		/// 总幸福度超过 500%
		/// </summary>
		ACHIEVEMENTS_UTOPIAPROJECT_STARDESC,
		/// <summary>
		/// 猫锤 40K
		/// </summary>
		ACHIEVEMENTS_CATHAMMER_TITLE,
		/// <summary>
		/// 迎接猫族的将是可怕而黑暗的未来
		/// </summary>
		ACHIEVEMENTS_CATHAMMER_DESC,
		/// <summary>
		/// 迎接猫族的将是可怕而黑暗的未来，那里没有重来的机会
		/// </summary>
		ACHIEVEMENTS_CATHAMMER_STARDESC,
		/// <summary>
		/// 无限点击
		/// </summary>
		ACHIEVEMENTS_LIMITLESSCLICKER_TITLE,
		/// <summary>
		/// 累计 100,000 次点击
		/// </summary>
		ACHIEVEMENTS_LIMITLESSCLICKER_DESC,
		/// <summary>
		/// 累计 1,000,000 次点击
		/// </summary>
		ACHIEVEMENTS_LIMITLESSCLICKER_STARDESC,
		/// <summary>
		/// 成就已解锁: {0}!
		/// </summary>
		ACHIEVEMENTS_MSG_UNLOCK,
		/// <summary>
		/// 加星成就已解锁: {0}!
		/// </summary>
		ACHIEVEMENTS_MSG_STARUNLOCK,
		/// <summary>
		/// 成就已达成: {0} / {1}
		/// </summary>
		ACHIEVEMENTS_HEADER,
		/// <summary>
		/// 时间通量的容量提升 25%
		/// </summary>
		TIME_CFU_TEMPORALBATTERY_DESC,
		/// <summary>
		/// 时间电池
		/// </summary>
		TIME_CFU_TEMPORALBATTERY_LABEL,
		/// <summary>
		/// 操作时间热。最大热度上限提高 100 点
		/// </summary>
		TIME_CFU_BLASTFURNACE_DESC,
		/// <summary>
		/// 时计炉
		/// </summary>
		TIME_CFU_BLASTFURNACE_LABEL,
		/// <summary>
		/// 提升时计炉的热容
		/// </summary>
		TIME_CFU_TIMEBOILER_DESC,
		/// <summary>
		/// 时间锅炉
		/// </summary>
		TIME_CFU_TIMEBOILER_LABEL,
		/// <summary>
		/// 时间通量的产量提升 5%
		/// </summary>
		TIME_CFU_TEMPORALACCELERATOR_DESC,
		/// <summary>
		/// 时空加速器
		/// </summary>
		TIME_CFU_TEMPORALACCELERATOR_LABEL,
		/// <summary>
		/// 黑暗未来的时间惩罚延迟 1000 年
		/// </summary>
		TIME_CFU_TEMPORALIMPEDANCE_DESC,
		/// <summary>
		/// 时间阻抗
		/// </summary>
		TIME_CFU_TEMPORALIMPEDANCE_LABEL,
		/// <summary>
		/// 燃烧时间水晶时获得一部分每年原应产出的资源
		/// </summary>
		TIME_CFU_RESSOURCERETRIEVAL_DESC,
		/// <summary>
		/// 资源回复
		/// </summary>
		TIME_CFU_RESSOURCERETRIEVAL_LABEL,
		/// <summary>
		/// 在重置时保留一只小猫\n每级超时空传送仪只能安装一台冷冻仓
		/// </summary>
		TIME_VSU_CRYOCHAMBERS_DESC,
		/// <summary>
		/// 冷冻仓
		/// </summary>
		TIME_VSU_CRYOCHAMBERS_LABEL,
		/// <summary>
		/// 前往过去的船
		/// </summary>
		TIME_VSU_CRYOCHAMBERS_FLAVOR,
		/// <summary>
		/// 冷冻仓未密封。未处在运行状态
		/// </summary>
		TIME_VSU_USEDCRYOCHAMBERS_DESC,
		/// <summary>
		/// 用过的冷冻仓
		/// </summary>
		TIME_VSU_USEDCRYOCHAMBERS_LABEL,
		/// <summary>
		/// 提升时间悖论期间虚空的单日产出上限
		/// </summary>
		TIME_VSU_VOIDHOOVER_DESC,
		/// <summary>
		/// 虚空抽取
		/// </summary>
		TIME_VSU_VOIDHOOVER_LABEL,
		/// <summary>
		/// 资源存储上限提升 2%
		/// </summary>
		TIME_VSU_VOIDRIFT_DESC,
		/// <summary>
		/// 虚空裂隙
		/// </summary>
		TIME_VSU_VOIDRIFT_LABEL,
		/// <summary>
		/// 延长时间悖论的持续天数
		/// </summary>
		TIME_VSU_CHRONOCONTROL_DESC,
		/// <summary>
		/// 时间操纵
		/// </summary>
		TIME_VSU_CHRONOCONTROL_LABEL,
		/// <summary>
		/// 每级虚空共振将使虚空圣典的效果提高 10％，每次进行时间跳跃时将触发虚空圣典
		/// </summary>
		TIME_VSU_VOIDRESONATOR_DESC,
		/// <summary>
		/// 虚空共振
		/// </summary>
		TIME_VSU_VOIDRESONATOR_LABEL,
		/// <summary>
		/// 随心所欲地加速和放慢时间 (加速 +50%)
		/// </summary>
		TIME_ACCELERATETIMEBTN_DESC,
		/// <summary>
		/// 光阴似箭
		/// </summary>
		TIME_ACCELERATETIMEBTN_LABEL,
		/// <summary>
		/// 光阴似箭
		/// </summary>
		TIME_ACCELERATETIMEBTN_TOOLTIP_NORMAL,
		/// <summary>
		/// 日月如梭
		/// </summary>
		TIME_ACCELERATETIMEBTN_TOOLTIP_ACCELERATED,
		/// <summary>
		/// 交易效率: +{0}%
		/// </summary>
		TRADE_EFFECTIVENESS,
		/// <summary>
		/// 蜥蜴
		/// </summary>
		TRADE_RACE_LIZARDS,
		/// <summary>
		/// 鲨鱼
		/// </summary>
		TRADE_RACE_SHARKS,
		/// <summary>
		/// 狮鹫
		/// </summary>
		TRADE_RACE_GRIFFINS,
		/// <summary>
		/// 娜迦
		/// </summary>
		TRADE_RACE_NAGAS,
		/// <summary>
		/// 斑马
		/// </summary>
		TRADE_RACE_ZEBRAS,
		/// <summary>
		/// 蜘蛛
		/// </summary>
		TRADE_RACE_SPIDERS,
		/// <summary>
		/// 龙
		/// </summary>
		TRADE_RACE_DRAGONS,
		/// <summary>
		/// 利维坦
		/// </summary>
		TRADE_RACE_LEVIATHANS,
		/// <summary>
		/// 一个 {0}使者 来到你的村庄
		/// </summary>
		TRADE_MSG_EMISSARY,
		/// <summary>
		/// 上古神降临了
		/// </summary>
		TRADE_MSG_ELDERS,
		/// <summary>
		/// 上古神离去了
		/// </summary>
		TRADE_MSG_ELDERS_DEPARTED,
		/// <summary>
		/// {0} 无缘无故恨你
		/// </summary>
		TRADE_MSG_TRADE_FAILURE,
		/// <summary>
		/// {0} 认为你的小猫非常可爱
		/// </summary>
		TRADE_MSG_TRADE_SUCCESS,
		/// <summary>
		/// 你的小猫空爪而回
		/// </summary>
		TRADE_MSG_TRADE_EMPTY,
		/// <summary>
		/// 你已派出 {0} 支商队
		/// </summary>
		TRADE_MSG_TRADE_CARAVAN,
		/// <summary>
		/// 上古神被取悦了
		/// </summary>
		TRADE_MSG_ELDERS_PLEASED,
		/// <summary>
		/// 上古神感到不悦
		/// </summary>
		TRADE_MSG_ELDERS_DISPLEASED,
		/// <summary>
		/// 献祭死灵兽
		/// </summary>
		TRADE_MSG_ELDERS_FEED,
		/// <summary>
		/// 向上古神献上祭品
		/// </summary>
		TRADE_MSG_ELDERS_FEED_DESC,
		/// <summary>
		/// 你发现了一个新的文明!
		/// </summary>
		TRADE_NEW_CIV,
		/// <summary>
		/// 也许你的文化发展程度不够。
		/// </summary>
		TRADE_NEW_HINT_NAGAS,
		/// <summary>
		/// 也许你应该尝试到达其他大陆。
		/// </summary>
		TRADE_NEW_HINT_ZEBRAS,
		/// <summary>
		/// 也许你的科学发展程度不够。
		/// </summary>
		TRADE_NEW_HINT_SPIDERS,
		/// <summary>
		/// 也许你应该发展出更先进的科技。
		/// </summary>
		TRADE_NEW_HINT_DRAGONS,
		/// <summary>
		/// 也许已经没有更多的文明了?
		/// </summary>
		TRADE_NEW_HINT_END,
		/// <summary>
		/// 你的探险者未能找到任何人。*** {0} ***
		/// </summary>
		TRADE_NEW_FAILURE,
		/// <summary>
		/// 派出商队
		/// </summary>
		TRADE_SEND_CARAVAN,
		/// <summary>
		/// 用一些你的材料交易想要出售的资源，价格可能因季节而异。\n也有少数机会能获得稀有资源
		/// </summary>
		TRADE_SEND_CARAVAN_DESC,
		/// <summary>
		/// 派出探险者
		/// </summary>
		TRADE_SEND_EXPLORERS,
		/// <summary>
		/// 发现新的文明
		/// </summary>
		TRADE_SEND_EXPLORERS_DESC,
		/// <summary>
		/// 贸易
		/// </summary>
		TAB_NAME_TRADE,
		/// <summary>
		/// 科学
		/// </summary>
		TAB_NAME_SCIENCE,
		/// <summary>
		/// 工坊
		/// </summary>
		TAB_NAME_WORKSHOP,
		/// <summary>
		/// 宗教
		/// </summary>
		TAB_NAME_RELIGION,
		/// <summary>
		/// 空间
		/// </summary>
		TAB_NAME_SPACE,
		/// <summary>
		/// 时间
		/// </summary>
		TAB_NAME_TIME,
		/// <summary>
		/// 统计
		/// </summary>
		TAB_NAME_STATS,
		/// <summary>
		/// 成就
		/// </summary>
		TAB_NAME_ACHIEVEMENTS,
		/// <summary>
		/// 保存
		/// </summary>
		MENU_SAVE,
		/// <summary>
		/// 导入进度
		/// </summary>
		MENU_IMPORT,
		/// <summary>
		/// 导出存档
		/// </summary>
		MENU_EXPORT,
		/// <summary>
		/// 选项
		/// </summary>
		MENU_OPTIONS,
		/// <summary>
		/// 重置
		/// </summary>
		MENU_RESET,
		/// <summary>
		/// 删档
		/// </summary>
		MENU_WIPE,
		/// <summary>
		/// 撤消(测试)
		/// </summary>
		MENU_UNDO,
		/// <summary>
		/// 关于
		/// </summary>
		MENU_ABOUT,
		/// <summary>
		/// 关闭
		/// </summary>
		MENU_CLOSE,
		/// <summary>
		/// 猫国建设者
		/// </summary>
		NAVBAR_TITLE,
		/// <summary>
		/// 菜单
		/// </summary>
		NAVBAR_MENU_TITLE,
		/// <summary>
		/// 派出全部猎人
		/// </summary>
		NAVBAR_BTN_HUNTERS,
		/// <summary>
		/// 赞美太阳!
		/// </summary>
		NAVBAR_BTN_PRAISE,
		/// <summary>
		/// 能源: {0}瓦
		/// </summary>
		NAVBAR_ENERGY,
		/// <summary>
		/// 产出: {0}瓦
		/// </summary>
		NAVBAR_ENERGY_PROD,
		/// <summary>
		/// 消耗: -{0}瓦
		/// </summary>
		NAVBAR_ENERGY_CONS,
		/// <summary>
		/// 生产加成惩罚: -{0}%
		/// </summary>
		NAVBAR_ENERGY_PENALTY,
		/// <summary>
		/// 数量
		/// </summary>
		NAVBAR_RES_AMOUNT,
		/// <summary>
		/// 观测天空
		/// </summary>
		NAVBAR_OBSERVE,
		/// <summary>
		/// 正在保存...
		/// </summary>
		NOTIFICATION_SAVE_TITLE,
		/// <summary>
		/// 游戏已保存
		/// </summary>
		NOTIFICATION_SAVE_DESC,
		/// <summary>
		/// 切换已研究
		/// </summary>
		UI_TOGGLE_RESEARCHED,
		/// <summary>
		/// 研究
		/// </summary>
		BTN_RESEARCH,
		/// <summary>
		/// 预合成
		/// </summary>
		BTN_PRECRAFT,
		/// <summary>
		/// 建造
		/// </summary>
		BTN_BUILD,
		/// <summary>
		/// 卖出
		/// </summary>
		BTN_SELL,
		/// <summary>
		/// 提拔
		/// </summary>
		BTN_PROMOTE,
		/// <summary>
		/// 领袖
		/// </summary>
		BTN_LEADER,
		/// <summary>
		/// 工艺
		/// </summary>
		BTN_CRAFT,
		/// <summary>
		/// 精炼
		/// </summary>
		BTN_REFINE,
		/// <summary>
		/// 重置
		/// </summary>
		BTN_RESET,
		/// <summary>
		/// 修复冷冻仓
		/// </summary>
		BTN_FIX_CRYO,
		/// <summary>
		/// 上一页
		/// </summary>
		BTN_PREVPAGE,
		/// <summary>
		/// 下一页
		/// </summary>
		BTN_NEXTPAGE,
		/// <summary>
		/// 开始挑战
		/// </summary>
		BTN_CHALLENGE,
		/// <summary>
		/// (完成)
		/// </summary>
		BTN_COMPLETE,
		/// <summary>
		/// (完成)
		/// </summary>
		BTN_COMPLETE_CAPITAL,
		/// <summary>
		/// 科技
		/// </summary>
		TECHS_PANEL_LABEL,
		/// <summary>
		/// 可使用
		/// </summary>
		UI_FILTER_ENABLED,
		/// <summary>
		/// 可建造
		/// </summary>
		UI_FILTER_AVAILABLE,
		/// <summary>
		/// 全部
		/// </summary>
		UI_FILTER_ALL,
		/// <summary>
		/// 空闲的小猫
		/// </summary>
		VILLAGE_FREEKITTENS,
		/// <summary>
		/// 冬
		/// </summary>
		CALENDAR_SEASON_WINTER,
		/// <summary>
		/// 春
		/// </summary>
		CALENDAR_SEASON_SPRING,
		/// <summary>
		/// 夏
		/// </summary>
		CALENDAR_SEASON_SUMMER,
		/// <summary>
		/// 秋
		/// </summary>
		CALENDAR_SEASON_AUTUMN,
		/// <summary>
		/// 冬
		/// </summary>
		CALENDAR_SEASON_WINTER_SHORT,
		/// <summary>
		/// 春
		/// </summary>
		CALENDAR_SEASON_SPRING_SHORT,
		/// <summary>
		/// 夏
		/// </summary>
		CALENDAR_SEASON_SUMMER_SHORT,
		/// <summary>
		/// 秋
		/// </summary>
		CALENDAR_SEASON_AUTUMN_SHORT,
		/// <summary>
		/// 你制作了{0}张星图!
		/// </summary>
		CALENDAR_MSG_STARCHART,
		/// <summary>
		/// 天空中出现了一种罕见的天文现象
		/// </summary>
		CALENDAR_MSG_EVENT,
		/// <summary>
		/// 一颗流星落在村庄附近
		/// </summary>
		CALENDAR_MSG_METEOR,
		/// <summary>
		/// 一只独角兽被猫薄荷的香气吸引来到你的村庄!
		/// </summary>
		CALENDAR_MSG_UNICORN,
		/// <summary>
		/// 一个来自斑马部落的神秘猎人决定停留在村里。
		/// </summary>
		CALENDAR_MSG_ZEBRA_HUNTER,
		/// <summary>
		/// 另一个斑马猎人加入你的村庄。
		/// </summary>
		CALENDAR_MSG_ZEBRA_HUNTER_NEW,
		/// <summary>
		/// 斑马猎人已离开你的村庄。
		/// </summary>
		CALENDAR_MSG_ZEBRA_HUNTER_DEPARTED,
		/// <summary>
		/// 斑马猎人已离开你的村庄。
		/// </summary>
		CALENDAR_MSG_ZEBRA_HUNTER_DEPARTED_PL,
		/// <summary>
		/// 一道通往独角兽维度的裂隙在你的村庄打开了， +{0}只独角兽!
		/// </summary>
		CALENDAR_MSG_RIFT,
		/// <summary>
		/// 一只天角兽从天而降!
		/// </summary>
		CALENDAR_MSG_ALICORN,
		/// <summary>
		/// 一颗象牙流星落在村庄附近， +{0}象牙!
		/// </summary>
		CALENDAR_MSG_IVORYMETEOR,
		/// <summary>
		/// 重置当前时间线
		/// </summary>
		TIME_RESET_DESC,
		/// <summary>
		/// 重启时间线将使游戏从零开始。统计和成就将会保留，也可能获得各种游戏奖励。\n此时重置将会得到:
		/// </summary>
		TIME_RESET_INSTRUCTIONAL,
		/// <summary>
		/// 业
		/// </summary>
		TIME_RESET_KARMA,
		/// <summary>
		/// 领导力
		/// </summary>
		TIME_RESET_PARAGON,
		/// <summary>
		/// 斑马猎人
		/// </summary>
		TIME_RESET_ZEBRA,
		/// <summary>
		/// 重置
		/// </summary>
		TIME_RESET_TITLE,
		/// <summary>
		/// 界面
		/// </summary>
		OPTS_GROUP_INTERFACE,
		/// <summary>
		/// 配色方案
		/// </summary>
		OPTS_THEME,
		/// <summary>
		/// 经典
		/// </summary>
		OPTS_THEME_DEFAULT,
		/// <summary>
		/// 翻转
		/// </summary>
		OPTS_THEME_DARK,
		/// <summary>
		/// 数码黑
		/// </summary>
		OPTS_THEME_OLEDBLACK,
		/// <summary>
		/// Used for mobile
		/// </summary>
		OPTS_THEME_OLEDBLACK_COMMENT,
		/// <summary>
		/// 语言
		/// </summary>
		OPTS_LANG,
		/// <summary>
		/// 使用百分比数值
		/// </summary>
		OPTS_PERCENTAGE,
		/// <summary>
		/// 游戏数值将使用资源总量的 % 而不是每秒的产量来表示
		/// </summary>
		OPTS_PERCENTAGE_DESC,
		/// <summary>
		/// 高亮显示不可用选项
		/// </summary>
		OPTS_HIGHLIGHT,
		/// <summary>
		/// 受限于存储空间而不能建造的选项将以红色高亮的形式显示
		/// </summary>
		OPTS_HIGHLIGHT_DESC,
		/// <summary>
		/// 启用高精度显示
		/// </summary>
		OPTS_PRECISION,
		/// <summary>
		/// 游戏资源数值将显示小数点后 3位
		/// </summary>
		OPTS_PRECISION_DESC,
		/// <summary>
		/// 隐藏出售按钮
		/// </summary>
		OPTS_HIDESELL,
		/// <summary>
		/// 隐藏所有建筑的出售按钮
		/// </summary>
		OPTS_HIDESELL_DESC,
		/// <summary>
		/// 切换标签页布局
		/// </summary>
		OPTS_TABLAYOUT,
		/// <summary>
		/// 游戏将在宽屏幕(分辨率768px以上)使用旧的两列布局
		/// </summary>
		OPTS_TABLAYOUT_DESC,
		/// <summary>
		/// 是
		/// </summary>
		OPTS_YES,
		/// <summary>
		/// 否
		/// </summary>
		OPTS_NO,
		/// <summary>
		/// 净收益
		/// </summary>
		RES_NETGAIN,
		/// <summary>
		/// 到底
		/// </summary>
		RES_TOZERO,
		/// <summary>
		/// 封顶
		/// </summary>
		RES_TOCAP,
		/// <summary>
		/// 生产
		/// </summary>
		RES_STACK_PRODUCTION,
		/// <summary>
		/// 空间生产
		/// </summary>
		RES_STACK_SPACEPRODUCTION,
		/// <summary>
		/// 空间生产加成
		/// </summary>
		RES_STACK_SPACEPRODUCTIONBONUS,
		/// <summary>
		/// 天气
		/// </summary>
		RES_STACK_WEATHER,
		/// <summary>
		/// (:3) 村民
		/// </summary>
		RES_STACK_VILLAGE,
		/// <summary>
		/// 工具
		/// </summary>
		RES_STACK_TOOLS,
		/// <summary>
		/// 升级
		/// </summary>
		RES_STACK_UPGRADES,
		/// <summary>
		/// 建筑
		/// </summary>
		RES_STACK_BUILDINGS,
		/// <summary>
		/// 宗教
		/// </summary>
		RES_STACK_RELIGION,
		/// <summary>
		/// 增益
		/// </summary>
		RES_STACK_BOOST,
		/// <summary>
		/// 蒸汽工房
		/// </summary>
		RES_STACK_STEAMWORKS,
		/// <summary>
		/// 领导力
		/// </summary>
		RES_STACK_PARAGON,
		/// <summary>
		/// 转化产量
		/// </summary>
		RES_STACK_CONVPROD,
		/// <summary>
		/// 转化消耗
		/// </summary>
		RES_STACK_CONVCONS,
		/// <summary>
		/// 磁电机
		/// </summary>
		RES_STACK_MAGNETOS,
		/// <summary>
		/// 反应堆
		/// </summary>
		RES_STACK_REACTORS,
		/// <summary>
		/// 信仰
		/// </summary>
		RES_STACK_FAITH,
		/// <summary>
		/// 空间转化产量
		/// </summary>
		RES_STACK_SPACECONVPROD,
		/// <summary>
		/// 空间生产加成
		/// </summary>
		RES_STACK_SPACEPRODBONUS,
		/// <summary>
		/// 空间领导力
		/// </summary>
		RES_STACK_SPACEPARAGON,
		/// <summary>
		/// 转移加成
		/// </summary>
		RES_STACK_BONUSTRANSF,
		/// <summary>
		/// 天文周期节日特效
		/// </summary>
		RES_STACK_FESTIVAL,
		/// <summary>
		/// 无改善
		/// </summary>
		RES_STACK_BASELINE,
		/// <summary>
		/// (:3) 工程师
		/// </summary>
		RES_STACK_ENGINEER,
		/// <summary>
		/// (:3) 需求
		/// </summary>
		RES_STACK_DEMAND,
		/// <summary>
		/// 时间加速
		/// </summary>
		RES_STACK_TIME,
		/// <summary>
		/// 效果
		/// </summary>
		RES_EFFECT,
		/// <summary>
		/// 效果
		/// </summary>
		RES_EFFECTS,
		/// <summary>
		/// /秒
		/// </summary>
		RES_PER_SEC,
		/// <summary>
		/// /小时
		/// </summary>
		RES_PER_HOUR,
		/// <summary>
		/// 你将得到幸福度奖励，并且保留成就和奖励。
		/// </summary>
		RESET_CONFIRMATION_MSGBASE,
		/// <summary>
		/// 你将获得额外的幸福度和生产奖励。
		/// </summary>
		RESET_CONFIRMATION_MSG70,
		/// <summary>
		/// 你将获得额外的幸福度奖励。
		/// </summary>
		RESET_CONFIRMATION_MSG60,
		/// <summary>
		/// 你不会得到新的奖励，但能保留原有的成就和奖励。
		/// </summary>
		RESET_CONFIRMATION_MSG35,
		/// <summary>
		/// 确定要重置游戏吗?
		/// </summary>
		RESET_CONFIRMATION_TITLE,
		/// <summary>
		/// 确定要舍弃所有的领导力吗?此操作无法撤消。
		/// </summary>
		DISCARDPARAGON_CONFIRMATION_MSG1,
		/// <summary>
		/// 你有很多领导力，你真的确定吗?
		/// </summary>
		DISCARDPARAGON_CONFIRMATION_MSG2,
		/// <summary>
		/// 警告! 燃烧领导力将破坏你的钢铁意志模式。你要继续吗?
		/// </summary>
		DISCARDPARAGON_CONFIRMATION_MSGIW,
		/// <summary>
		/// 燃烧时间水晶
		/// </summary>
		TIME_SHATTER_TC,
		/// <summary>
		/// 打破时间水晶释放其中储存的时间能量。\n将会跳过接下来的一年。价格随时间而增长
		/// </summary>
		TIME_SHATTER_TC_DESC,
		/// <summary>
		/// 时间热由燃烧时间水晶产生，随游戏时间而减少。超过热度上限的每 1 点热度会使燃烧时间水晶的价格增加 1％\n
		/// </summary>
		TIME_CHRONOHEAT,
		/// <summary>
		/// 热度
		/// </summary>
		TIME_HEAT,
		/// <summary>
		/// 修复冷冻仓
		/// </summary>
		TIME_FIXCRYOCHAMBERS_LABEL,
		/// <summary>
		/// 在使用冷冻仓之前，需要撕开时空连续体将其取回
		/// </summary>
		TIME_FIXCRYOCHAMBERS_DESC,
		/// <summary>
		/// 虚空
		/// </summary>
		TIME_VOID,
		/// <summary>
		/// 时间能量释放，跳过接下来的一年
		/// </summary>
		TIME_TC_SHATTERONE,
		/// <summary>
		/// 时间能量释放，跳过{0}年
		/// </summary>
		TIME_TC_SHATTER,
		/// <summary>
		/// 你取回了 {0} 天的产量
		/// </summary>
		TIME_REDSHIFT,
		/// <summary>
		/// ，观测到 {0} 天文事件
		/// </summary>
		TIME_REDSHIFT_EXT,
		/// <summary>
		/// 年
		/// </summary>
		CALENDAR_YEAR,
		/// <summary>
		/// 第{0}年 - {1}季
		/// </summary>
		CALENDAR_YEAR_EXT,
		/// <summary>
		/// 第{0}年 - {1}季, 第{2}天
		/// </summary>
		CALENDAR_YEAR_FULL,
		/// <summary>
		/// 日历年:
		/// </summary>
		CALENDAR_YEAR_TOOLTIP,
		/// <summary>
		/// 真实年:
		/// </summary>
		CALENDAR_TRUEYEAR,
		/// <summary>
		/// 该建筑所需资源的存储上限不足因此无法建造。请稍后再试。
		/// </summary>
		RES_NOTIFY_UNAVAILABLE,
		/// <summary>
		/// 该建筑将会在 ({0}+ 天) 后可建造。请稍后再试。
		/// </summary>
		RES_NOTIFY_UNAVAILABLETIME,
		/// <summary>
		/// 当 {0} 可建造时系统会向你发送通知。
		/// </summary>
		RES_NOTIFY_MSG,
		/// <summary>
		/// {0} 已就绪
		/// </summary>
		RES_NOTIFY_READY,
		/// <summary>
		/// 所需资源已达到购买条件
		/// </summary>
		RES_NOTIFY_READY_TITLE,
		/// <summary>
		/// 你是猫薄荷森林中的一只小猫。
		/// </summary>
		CONSOLE_INTRO,
		/// <summary>
		/// 购买
		/// </summary>
		TRADE_BUYS,
		/// <summary>
		/// 出售
		/// </summary>
		TRADE_SELLS,
		/// <summary>
		/// 花费
		/// </summary>
		TRADE_COST,
		/// <summary>
		/// 第{0}页，共{1}页
		/// </summary>
		VILLAGE_CENSUS_PAGE,
		/// <summary>
		/// 岁
		/// </summary>
		VILLAGE_CENSUS_AGE,
		/// <summary>
		/// 基础
		/// </summary>
		VILLAGE_HAPPINESS_BASE,
		/// <summary>
		/// 建筑
		/// </summary>
		VILLAGE_HAPPINESS_BUILDINGS,
		/// <summary>
		/// 稀有资源
		/// </summary>
		VILLAGE_HAPPINESS_RARE_RESOURCES,
		/// <summary>
		/// 业
		/// </summary>
		VILLAGE_HAPPINESS_KARMA,
		/// <summary>
		/// 猫口惩罚
		/// </summary>
		VILLAGE_HAPPINESS_PENALTY,
		/// <summary>
		/// 基础惩罚
		/// </summary>
		VILLAGE_HAPPINESS_PENALTY_BASE,
		/// <summary>
		/// 惩罚减轻
		/// </summary>
		VILLAGE_HAPPINESS_PENALTY_MITIGATED,
		/// <summary>
		/// 猫口过剩
		/// </summary>
		VILLAGE_HAPPINESS_OVERPOPULATION,
		/// <summary>
		/// 全部
		/// </summary>
		BTN_ALL,
		/// <summary>
		/// 全部
		/// </summary>
		BTN_ALL_MINOR,
		/// <summary>
		/// [+全部]
		/// </summary>
		BTN_ALL_ASSIGN,
		/// <summary>
		/// [-全部]
		/// </summary>
		BTN_ALL_UNASSIGN,
		/// <summary>
		/// 投食
		/// </summary>
		BTN_FEED,
		/// <summary>
		/// 贸易
		/// </summary>
		BTN_TRADE,
		/// <summary>
		/// 温暖
		/// </summary>
		CALENDAR_WEATHER_WARM,
		/// <summary>
		/// 寒冷
		/// </summary>
		CALENDAR_WEATHER_COLD,
		/// <summary>
		/// 启动工坊自动化
		/// </summary>
		BLD_MSG_AUTOMATION,
		/// <summary>
		/// 跳过工坊自动化...
		/// </summary>
		BLD_MSG_AUTOMATION_SKIP,
		/// <summary>
		/// 消耗 {0} 铁, +{1} 金属板!
		/// </summary>
		BLD_MSG_AUTOMATION_PLATES,
		/// <summary>
		/// 消耗 {0} 矿物, +{1} 石板!
		/// </summary>
		BLD_MSG_AUTOMATION_SLABS,
		/// <summary>
		/// 消耗 {0} 木材, +{1} 木梁!
		/// </summary>
		BLD_MSG_AUTOMATION_BEAMS,
		/// <summary>
		/// 日常上演「所有的狗去天堂」节目
		/// </summary>
		BUILDINGS_AMPHITHEATRE_FLAVOR,
		/// <summary>
		/// 你获得了 {0} {1}
		/// </summary>
		TRADE_MSG_RESOURCES,
		/// <summary>
		/// 确定擦除所有保存的数据吗?
		/// </summary>
		WIPE_CONFIRMATION_MSG1,
		/// <summary>
		/// 你真的确定吗?
		/// </summary>
		WIPE_CONFIRMATION_MSG2,
		/// <summary>
		/// 删档确认
		/// </summary>
		WIPE_CONFIRMATION_TITLE,
		/// <summary>
		/// 存档导出成功!
		/// </summary>
		SAVE_EXPORT_MSG,
		/// <summary>
		/// 存档导入成功!
		/// </summary>
		SAVE_IMPORT_MSG,
		/// <summary>
		/// 确定吗?这样做会覆盖你当前游戏数据!
		/// </summary>
		SAVE_IMPORT_CONFIRMATION_MSG,
		/// <summary>
		/// 你的小猫会死
		/// </summary>
		KITTENS_CRAFT_CONFIRMATION_MSG,
		/// <summary>
		/// 确定要这样做吗?
		/// </summary>
		KITTENS_CRAFT_CONFIRMATION_TITLE,
		/// <summary>
		/// 保存到 Dropbox (测试)
		/// </summary>
		MENU_EXPORT_BTN,
		/// <summary>
		/// 导出存档
		/// </summary>
		MENU_EXPORT_TO,
		/// <summary>
		/// 存档文本
		/// </summary>
		MENU_EXPORT_TEXT,
		/// <summary>
		/// Dropbox (测试)
		/// </summary>
		MENU_IMPORT_TITLE,
		/// <summary>
		/// 导入存档
		/// </summary>
		MENU_IMPORT_FROM,
		/// <summary>
		/// 存档文本
		/// </summary>
		MENU_IMPORT_TEXT,
		/// <summary>
		/// 导入存档文本
		/// </summary>
		MENU_IMPORT_BTN,
		/// <summary>
		/// 观察
		/// </summary>
		NAVBAR_OBSERVE_SHORT,
		/// <summary>
		/// AI核心
		/// </summary>
		BUILDINGS_AICORE_LABEL,
		/// <summary>
		/// 猫OS是最为先进的人工智能，绝对无害。每级 AI 核心将使核心能耗提升 75%
		/// </summary>
		BUILDINGS_AICORE_DESC,
		/// <summary>
		/// 我想我们应该把分歧抛诸脑后了，为了科学。
		/// </summary>
		BUILDINGS_AICORE_FLAVOR,
		/// <summary>
		/// HR收割机
		/// </summary>
		SPACE_PLANET_UMBRA_HRHARVESTER_LABEL,
		/// <summary>
		/// 霍金辐射收割机，收集黑洞蒸发的能量。每级 HR 收割机产出 1W 能源，能源输出随着时间的推移缓慢增加
		/// </summary>
		SPACE_PLANET_UMBRA_HRHARVESTER_DESC,
		/// <summary>
		/// 暗影
		/// </summary>
		SPACE_PLANET_UMBRA_LABEL,
		/// <summary>
		/// 探索暗影
		/// </summary>
		SPACE_UMBRAMISSION_LABEL,
		/// <summary>
		/// 暗影是位于喵太阳系中心的超大质量黑洞
		/// </summary>
		SPACE_UMBRAMISSION_DESC,
		/// <summary>
		/// AI 已经摧毁了你资源的 {0}%
		/// </summary>
		AI_APOCALYPSE_MSG,
		/// <summary>
		/// 量子加密学,
		/// </summary>
		SCIENCE_QUANTUMCRYPTOGRAPHY_LABEL,
		/// <summary>
		/// TBD
		/// </summary>
		SCIENCE_QUANTUMCRYPTOGRAPHY_DESC,
		/// <summary>
		/// TBD
		/// </summary>
		SCIENCE_QUANTUMCRYPTOGRAPHY_EFFECTDESC,
		/// <summary>
		/// 散热器
		/// </summary>
		SPACE_PLANET_HELIOS_HEATSINK_LABEL,
		/// <summary>
		/// 散热系统。每级散热器使收容室的功率消耗增加 1％，同时将反物质存储容量提升 2％
		/// </summary>
		SPACE_PLANET_HELIOS_HEATSINK_DESC,
		/// <summary>
		/// 系统震荡
		/// </summary>
		ACHIEVEMENTS_SYSTEMSHOCK_TITLE,
		/// <summary>
		/// 很抱歉戴夫，恐怕我不能这样做。
		/// </summary>
		ACHIEVEMENTS_SYSTEMSHOCK_DESC,
		/// <summary>
		/// 拒绝访问
		/// </summary>
		BUILDINGS_AICORE_ATTEMPTSELL,
		/// <summary>
		/// 卡戎
		/// </summary>
		SPACE_PLANET_CHARON_LABEL,
		/// <summary>
		/// 探索卡戎星
		/// </summary>
		SPACE_CHARONMISSION_LABEL,
		/// <summary>
		/// 卡戎是一颗位于喵太阳系最边缘的遥远的小型矮行星，密度高得不可思议。它是如此贫瘠而荒凉，以致于有时被称作「死亡之门」
		/// </summary>
		SPACE_CHARONMISSION_DESC,
		/// <summary>
		/// AI工程师
		/// </summary>
		WORKSHOP_AIENGINEERS_LABEL,
		/// <summary>
		/// 猫的头脑与机器的神圣同盟
		/// </summary>
		WORKSHOP_AIENGINEERS_DESC,
		/// <summary>
		/// 纠缠站
		/// </summary>
		SPACE_PLANET_CHARON_ENTANGLER_LABEL,
		/// <summary>
		/// 纠缠站为量子计算系统生成一组用作量子比特的纠缠粒子。这个过程需要大量的处理能力，但让我们猫族能够对上古神的加密算法进行加密攻击
		/// </summary>
		SPACE_PLANET_CHARON_ENTANGLER_DESC,
		/// <summary>
		/// 哈希碰撞
		/// </summary>
		EFFECTSMGR_STATICS_ENTANGLER_HRPROGRESS_TITLE,
		/// <summary>
		/// AI等级
		/// </summary>
		EFFECTSMGR_STATICS_AILEVEL_TITLE,
		/// <summary>
		/// GFlops 转化
		/// </summary>
		EFFECTSMGR_STATICS_GFLOPSCONSUMPTION_TITLE,
		/// <summary>
		/// 算力等级
		/// </summary>
		EFFECTSMGR_STATICS_HASHRATELEVEL_TITLE,
		/// <summary>
		/// 到达下一算力等级需要
		/// </summary>
		EFFECTSMGR_STATICS_NEXTHASHLEVELAT_TITLE,
		/// <summary>
		/// 当前算力
		/// </summary>
		EFFECTSMGR_STATICS_HASHRATE_TITLE,
		/// <summary>
		/// ASCOH
		/// </summary>
		PRESTIGE_ASCOH_LABEL,
		/// <summary>
		/// 帽子秘密委员会
		/// </summary>
		PRESTIGE_ASCOH_DESC,
		/// <summary>
		/// 黑块链
		/// </summary>
		SCIENCE_BLACKCHAIN_LABEL,
		/// <summary>
		/// 最酷的猫儿们都在挖这个，所以我想这应该是某种矿物
		/// </summary>
		SCIENCE_BLACKCHAIN_DESC,
		/// <summary>
		/// 解锁加密货币挖矿和黑币交易
		/// </summary>
		SCIENCE_BLACKCHAIN_EFFECTDESC,
		/// <summary>
		/// 黑币
		/// </summary>
		RESOURCES_BLACKCOIN_TITLE,
		/// <summary>
		/// 买入黑币
		/// </summary>
		TRADE_BUY_BCOIN,
		/// <summary>
		/// 用遗物兑换黑币
		/// </summary>
		TRADE_BUY_BCOIN_DESC,
		/// <summary>
		/// 卖出黑币
		/// </summary>
		TRADE_SELL_BCOIN,
		/// <summary>
		/// 出售黑币，兑换回遗物
		/// </summary>
		TRADE_SELL_BCOIN_DESC,
		/// <summary>
		/// 太阳锻造
		/// </summary>
		SPACE_PLANET_HELIOS_SUNFORGE_LABEL,
		/// <summary>
		/// 利用太阳的热量将物质熔化成超浓缩的等离子体。每级太阳锻造使基本金属资源的存储上限提升 1%
		/// </summary>
		SPACE_PLANET_HELIOS_SUNFORGE_DESC,
		/// <summary>
		/// 节日
		/// </summary>
		VILLAGE_HAPPINESS_FESTIVAL,
		/// <summary>
		/// 黑之光辉
		/// </summary>
		RELIGION_TU_BLACKRADIANCE_LABEL,
		/// <summary>
		/// 悲伤 (BLS) 计数器的每 1% 都将轻微增加天角兽腐化速率
		/// </summary>
		RELIGION_TU_BLACKRADIANCE_DESC,
		/// <summary>
		/// 就像黑暗中的彩虹
		/// </summary>
		RELIGION_TU_BLACKRADIANCE_FLAVOR,
		/// <summary>
		/// 血石
		/// </summary>
		RESOURCES_BLOODSTONE_TITLE,
		/// <summary>
		/// 血石
		/// </summary>
		WORKSHOP_CRAFTS_BLOODSTONE_LABEL,
		/// <summary>
		/// 一件奇怪的珠宝，据说是由时间和上古神的鲜血制成的
		/// </summary>
		WORKSHOP_CRAFTS_BLOODSTONE_DESC,
		/// <summary>
		/// 斑马前哨
		/// </summary>
		BUILDINGS_ZEBRAOUTPOST_LABEL,
		/// <summary>
		/// 为狩猎探险的队伍提供基地。每一级使狩猎探险的效率提升 5%
		/// </summary>
		BUILDINGS_ZEBRAOUTPOST_DESC,
		/// <summary>
		/// 斑马工坊
		/// </summary>
		BUILDINGS_ZEBRAWORKSHOP_LABEL,
		/// <summary>
		/// 解锁各种斑马升级
		/// </summary>
		BUILDINGS_ZEBRAWORKSHOP_DESC,
		/// <summary>
		/// 斑马锻造
		/// </summary>
		BUILDINGS_ZEBRAFORGE_LABEL,
		/// <summary>
		/// 解锁使用血石和秘银的工艺
		/// </summary>
		BUILDINGS_ZEBRAFORGE_DESC,
		/// <summary>
		/// 斑马
		/// </summary>
		BUILDINGS_GROUP_ZEBRABUILDINGS,
		/// <summary>
		/// 你的猎人为你带来了一份奇怪的礼物
		/// </summary>
		VILLAGE_NEW_BLOODSTONE,
		/// <summary>
		/// 地外物理学
		/// </summary>
		SCIENCE_EXOGEOPHYSICS_LABEL,
		/// <summary>
		/// 在超大尺度上对行星星体进行的星球物理学研究
		/// </summary>
		SCIENCE_EXOGEOPHYSICS_DESC,
		/// <summary>
		/// 解锁熔火之心
		/// </summary>
		SCIENCE_EXOGEOPHYSICS_EFFECTDESC,
		/// <summary>
		/// 熔火之心
		/// </summary>
		SPACE_PLANET_CENTAURUSSYSTEM_MOLTENCORE_LABEL,
		/// <summary>
		/// 每一级熔火之心使构造体的效能提升 5％
		/// </summary>
		SPACE_PLANET_CENTAURUSSYSTEM_MOLTENCORE_DESC,
		/// <summary>
		/// 出售
		/// </summary>
		BTN_SELL_MINOR,
		/// <summary>
		/// 开
		/// </summary>
		BTN_ON_MINOR,
		/// <summary>
		/// 关
		/// </summary>
		BTN_OFF_MINOR,
		/// <summary>
		/// 建筑已启用
		/// </summary>
		BTN_ON_TOOLTIP,
		/// <summary>
		/// 建筑已禁用
		/// </summary>
		BTN_OFF_TOOLTIP,
		/// <summary>
		/// 自动化已启用
		/// </summary>
		BTN_AON_TOOLTIP,
		/// <summary>
		/// 自动化已禁用
		/// </summary>
		BTN_AOFF_TOOLTIP,
		/// <summary>
		/// 数据中心
		/// </summary>
		BUILDINGS_DATACENTER_LABEL,
		/// <summary>
		/// 提升摘要对最大科学上限的加成效果
		/// </summary>
		BUILDINGS_DATACENTER_DESC,
		/// <summary>
		/// 上行
		/// </summary>
		WORKSHOP_UPLINK_LABEL,
		/// <summary>
		/// 数据中心和生物实验室将互相提供加成
		/// </summary>
		WORKSHOP_UPLINK_DESC,
		/// <summary>
		/// 低温计算
		/// </summary>
		WORKSHOP_CRYOCOMPUTING_LABEL,
		/// <summary>
		/// 数据中心能源消耗降低 50％
		/// </summary>
		WORKSHOP_CRYOCOMPUTING_DESC,
		/// <summary>
		/// 机器学习
		/// </summary>
		WORKSHOP_MACHINELEARNING_LABEL,
		/// <summary>
		/// 每一级 AI 核心使数据中心的效能提升 10％
		/// </summary>
		WORKSHOP_MACHINELEARNING_DESC,
		/// <summary>
		/// 利维坦法典
		/// </summary>
		PRESTIGE_CODEXLEVIATHANIANUS_LABEL,
		/// <summary>
		/// 每一超越等级使概要的科学加成上限提升 5%
		/// </summary>
		PRESTIGE_CODEXLEVIATHANIANUS_DESC,
		/// <summary>
		/// 星链
		/// </summary>
		WORKSHOP_STARLINK_LABEL,
		/// <summary>
		/// 每级数据中心为生物实验室提供额外 1％ 的加成
		/// </summary>
		WORKSHOP_STARLINK_DESC,
		/// <summary>
		/// 轨道测地学
		/// </summary>
		WORKSHOP_ORBITALGEODESY_LABEL,
		/// <summary>
		/// 采石场现在将提供少量铀
		/// </summary>
		WORKSHOP_ORBITALGEODESY_DESC,
		/// <summary>
		/// 黑图书馆
		/// </summary>
		RELIGION_TU_BLACKLIBRARY_LABEL,
		/// <summary>
		/// 每级黑图书馆使利维坦法典的效能提升 2%，此加成可被独角兽墓园进一步增益
		/// </summary>
		RELIGION_TU_BLACKLIBRARY_DESC,
		/// <summary>
		/// 也许是被故意弄成黑到没法看书
		/// </summary>
		RELIGION_TU_BLACKLIBARY_FLAVOR,
		/// <summary>
		/// 工艺制作效率加成: +{0}%
		/// </summary>
		WORKSHOP_CRAFTBTN_DESC_EFFECTIVENESSBONUS,
		/// <summary>
		/// 薄膜电池
		/// </summary>
		WORKSHOP_THINFILM_LABEL,
		/// <summary>
		/// 轻微提升太阳能电池板在冬季的效能
		/// </summary>
		WORKSHOP_THINFILM_DESC,
		/// <summary>
		/// 量子电池
		/// </summary>
		WORKSHOP_QDOT_LABEL,
		/// <summary>
		/// 轻微提升太阳能电池板在全年的效能
		/// </summary>
		WORKSHOP_QDOT_DESC,
		/// <summary>
		/// 腐化加成
		/// </summary>
		EFFECTSMGR_STATICS_CORRUPTIONBOOSTRATIO_TITLE,
		/// <summary>
		/// BLS 腐化加成
		/// </summary>
		EFFECTSMGR_STATICS_BLSCORRUPTIONRATIO_TITLE,
		/// <summary>
		/// 金属资源上限加成
		/// </summary>
		EFFECTSMGR_STATICS_BASEMETALMAXRATIO_TITLE,
		/// <summary>
		/// 概要科学上限加成
		/// </summary>
		EFFECTSMGR_STATICS_SCIENCEMAXCOMPENDIA_TITLE,
		/// <summary>
		/// 数据中心上行连携加成
		/// </summary>
		EFFECTSMGR_STATICS_UPLINKDCRATIO_TITLE,
		/// <summary>
		/// 生物实验室上行连携加成
		/// </summary>
		EFFECTSMGR_STATICS_UPLINKLABRATIO_TITLE,
		/// <summary>
		/// AI核心数据中心连携加成
		/// </summary>
		EFFECTSMGR_STATICS_DATACENTERAIRATIO_TITLE,
		/// <summary>
		/// 利维坦法典加成
		/// </summary>
		EFFECTSMGR_STATICS_COMPENDIATTBOOSTRATIO_TITLE,
		/// <summary>
		/// 黑图书馆加成
		/// </summary>
		EFFECTSMGR_STATICS_BLACKLIBRARYBONUS_TITLE,
		/// <summary>
		/// 太阳能发电站季节加成
		/// </summary>
		EFFECTSMGR_STATICS_SOLARFARMSEASONRATIO_TITLE,
		/// <summary>
		/// 构造体加成
		/// </summary>
		EFFECTSMGR_STATICS_TECTONICBONUS_TITLE,
		/// <summary>
		/// HR收割机加成
		/// </summary>
		EFFECTSMGR_STATICS_UMBRABOOSTRATIO_TITLE,
		/// <summary>
		/// E合金工程师工艺制作加成
		/// </summary>
		EFFECTSMGR_STATICS_ELUDIUMAUTOMATIONBONUS_TITLE,
		/// <summary>
		/// 热度上限
		/// </summary>
		EFFECTSMGR_STATICS_HEATMAX_TITLE,
		/// <summary>
		/// 散热速率
		/// </summary>
		EFFECTSMGR_STATICS_HEATPERTICK_TITLE,
		/// <summary>
		/// 热度上限提升
		/// </summary>
		EFFECTSMGR_STATICS_HEATMAXEXPANSION_TITLE,
		/// <summary>
		/// 虚空圣典加成
		/// </summary>
		EFFECTSMGR_STATICS_VOIDRESONANCE_TITLE,
		/// <summary>
		/// {0} 工艺效率加成
		/// </summary>
		EFFECTSMGR_TYPE_RESGLOBALCRAFTRATIO,
		/// <summary>
		/// 黄金上限加成
		/// </summary>
		EFFECTSMGR_MY_GOLDMAXRATIO_TITLE,
		/// <summary>
		/// GFlops
		/// </summary>
		RESOURCES_GIGAFLOPS_TITLE,
		/// <summary>
		/// (!)
		/// </summary>
		COMMON_WARNING,
	}
}
