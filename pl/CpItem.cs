using System;

namespace CpItemData
{
	public class CpItem
	{
		[Serializable]
		public class CpItemData
		{
			public int itemflag;

			public int itemgraphic;

			public string itemname;

			public string[] itemcomment;

			public string itemname_us;

			public string[] itemcomment_us;

			public string itemname_ko;

			public string[] itemcomment_ko;

			public CpItemData()
			{
				itemcomment = new string[3];
				itemcomment_us = new string[3];
				itemcomment_ko = new string[3];
			}

			public CpItemData(int flagNo, int graphicNo, string name, string commnet0, string commnet1, string commnet2, string name_us, string commnet0_us, string commnet1_us, string commnet2_us, string name_ko, string commnet0_ko, string commnet1_ko, string commnet2_ko)
			{
				itemflag = flagNo;
				itemgraphic = graphicNo;
				itemname = name;
				itemcomment = new string[3];
				itemcomment_us = new string[3];
				itemcomment_ko = new string[3];
				itemcomment[0] = commnet0;
				itemcomment[1] = commnet1;
				itemcomment[2] = commnet2;
				itemname_us = name_us;
				itemcomment_us[0] = commnet0_us;
				itemcomment_us[1] = commnet1_us;
				itemcomment_us[2] = commnet2_us;
				itemname_ko = name_ko;
				itemcomment_ko[0] = commnet0_ko;
				itemcomment_ko[1] = commnet1_ko;
				itemcomment_ko[2] = commnet2_ko;
			}
		}

		public enum ITEM_DEFINE
		{
			_CHAPTER1_ITEMTOP = 0,
			_CHAPTER1_ITEMCOUNT = 6,
			_CHAPTER2_ITEMTOP = 7,
			_CHAPTER2_ITEMCOUNT = 8,
			_CHAPTER3_ITEMTOP = 16,
			_CHAPTER3_ITEMCOUNT = 9,
			_CHAPTER4_ITEMTOP = 26,
			_CHAPTER4_ITEMCOUNT = 11,
			_CHAPTER5_ITEMTOP = 38,
			_CHAPTER5_ITEMCOUNT = 13,
			_EXTRA1_ITEMTOP = 52,
			_EXTRA1_ITEMCOUNT = 5,
			_EXTRA2_ITEMTOP = 58,
			_EXTRA2_ITEMCOUNT = 1,
			_EXTRA3_ITEMTOP = 60,
			_EXTRA3_ITEMCOUNT = 21,
			_EXTRA5_ITEMTOP = 60,
			_EXTRA5_ITEMCOUNT = 21,
			_EXTRA6_ITEMTOP = 60,
			_EXTRA6_ITEMCOUNT = 21,
			_EXTRA7_ITEMTOP = 60,
			_EXTRA7_ITEMCOUNT = 21,
			_EXTRA8_ITEMTOP = 60,
			_EXTRA8_ITEMCOUNT = 21,
			_EXTRA9_ITEMTOP = 60,
			_EXTRA9_ITEMCOUNT = 21,
			_EXTRA10_ITEMTOP = 60,
			_EXTRA10_ITEMCOUNT = 21,
			_EXTRA11_ITEMTOP = 60,
			_EXTRA11_ITEMCOUNT = 21,
			_CHAP_1_ITEM_MAX = 7,
			_CHAP_2_ITEM_MAX = 9,
			_CHAP_3_ITEM_MAX = 10,
			_CHAP_4_ITEM_MAX = 12,
			_CHAP_5_ITEM_MAX = 14,
			_CHAP_EX1_ITEM_MAX = 6,
			_CHAP_EX2_ITEM_MAX = 2,
			_CHAP_EX31_ITEM_MAX = 2,
			_01_boroita = 0,
			_02_3_Akagi = 1,
			_03_hokensitukagi = 2,
			_04_matchbako = 3,
			_05_Alcoholbin = 4,
			_06_yogoretabaketu = 5,
			_07_powerstone = 6,
			_08_kuginuki = 7,
			_09_hannin_no_zange = 8,
			_10_yuka_no_omamori = 9,
			_11_bekkan_no_kagi = 10,
			_12_mayoke_no_kutu = 11,
			_13_hamayaburi_no_suisyou = 12,
			_14_DVtape_1 = 13,
			_15_naomi_keitai = 14,
			_16_seiko_keitai = 15,
			_17_asabukuro = 16,
			_18_youmuinsitu_kagi = 17,
			_19_tiisana_kagi = 18,
			_20_suiatutyouseisitu_kagi = 19,
			_21_Valvehandol = 20,
			_22_dairiseki_no_tyoukoku = 21,
			_23_naomi_no_kakuseisyou = 22,
			_24_yuka_no_kutu = 23,
			_25_naho_no_tetyou = 24,
			_26_morishige_no_keitai = 25,
			_27_kibiki_no_miniDVtape_2 = 26,
			_28_timamire_no_DVtape = 27,
			_29_akago_no_zou = 28,
			_30_yoshie_no_nikki = 29,
			_31_kuroneko_no_nuigurumi = 30,
			_32_netuke_no_tuita_tiisana_kagi = 31,
			_33_asabukuro_satiko = 32,
			_34_tihaya_no_porch = 33,
			_35_hosigata_sunglasses = 34,
			_36_Elegance_na_megane = 35,
			_37_softbou = 36,
			_38_shinbun_kiji = 37,
			_39_bunkajingyo_atama = 38,
			_40_bunkajingyo_karada = 39,
			_41_morishige_keitai_2 = 40,
			_42_ryouka_no_kakuseisyou = 41,
			_43_ENUM_END = 42
		}

		public static CpItemData[] cap1item = new CpItemData[7]
		{
			new CpItemData(5, 0, "ボロの板切れ", "あちこち傷んでボロボロの板切れ。", "簡単に割れてしまいそうだ。", "", "Loose Board", " A plank of wood pried up from the", " floor. Has seen better days, but", " still seems relatively sturdy.", "낡은 널빤지 ", "곳곳이 상해서 너덜너덜해진 널빤지. ", "쉽게 부러질 것 같다. ", " "),
			new CpItemData(219, 1, "不明の鍵", "用途不明の鍵。", "古い物のようで簡単な形状をしている。", "", "Unknown Key", " A key to some unknown lock.", " Has that classic key shape,", " suggesting it's rather old.", "알 수 없는 열쇠 ", "용도가 불명한 열쇠. ", "오래전 것이라 그런지 간소한 모양새다. ", " "),
			new CpItemData(107, 5, "汚れたバケツ", "底の腐蝕が進んだ古いバケツ。", "中には小さな虫が沢山わいている。", "", "Filthy Bucket", " An old, heavily corroded bucket", " full of moldy deposits and highly", " sated, energetic insects.", "더러운 양동이 ", "바닥에 부식이 진행된 낡은 양동이. ", "안에는 작은 벌레가 잔뜩 꼬여 있다. ", " "),
			new CpItemData(55, 2, "保健室の鍵", "白く輝く綺麗な鍵。", "【保健室】とラベルが貼ってある。", "", "Infirmary Key", " A shiny metallic key with a pretty", " white finish. The attached label", " reads, ”Infirmary.”", "보건실 열쇠 ", "하얗게 빛나는 예쁜 열쇠. ", "【보건실】이라는 라벨이 붙어 있다. ", " "),
			new CpItemData(40, 3, "汚れたマッチ", "ストーブの横に落ちていた古いマッチ。", "中身は沢山残っている。", "", "Box of Matches", " A box of loose matches found near", " an old-fashioned space heater.", " There are still quite a few left.", "더러운 성냥 ", "난로 옆에 떨어져 있던 낡은 성냥. ", "성냥이 가득 담겨 있다. ", " "),
			new CpItemData(39, 4, "アルコール瓶", "中身のたっぷり入った、消毒用の", "アルコール瓶。", "", "Rubbing Alcohol", " A very old bottle of rubbing", " alcohol. Still filled almost", " all the way to the top.", "알코올병 ", "알코올이 듬뿍 들어간 ", "소독용 알코올병. ", " "),
			new CpItemData(0, 0, "", "", "", "", "", "", "", "", " ", " ", " ", " ")
		};

		public static CpItemData[] cap2item = new CpItemData[9]
		{
			new CpItemData(179, 6, "パワーストーン", "結衣の拾った、紫色の綺麗な水晶。", "持つ者を邪悪な気から護る力があると", "いう。", "Power Stone", " A pale violet crystal found by Ms.", " Yui. Protects its bearer from", " harm.", "파워 스톤 ", "유이가 주운, 자줏빛이 감도는 예쁜 수정. ", "이것을 지니고 있는 자를 사악한 것들로부터 ", "지켜주는 힘이 있다고 한다. "),
			new CpItemData(54, 6, "パワーストーン", "結衣から貰った、紫色の綺麗な水晶。", "持つ者を邪悪な気から護る力があると", "いう。", "Power Stone", " A pale violet crystal found by Ms.", " Yui. Protects its bearer from", " harm.", "파워 스톤 ", "유이가 주운, 자줏빛이 감도는 예쁜 수정. ", "이것을 지니고 있는 자를 사악한 것들로부터 ", "지켜주는 힘이 있다고 한다. "),
			new CpItemData(180, 1, "３のＡの鍵", "【３のＡ】と書かれた古びた鍵。", "錆びついてボロボロだが…", "", "Room 3-A Key", " An old key with ”3-A”written on", " it. Seems fairly rusted, but", " should still turn.", "3-A 열쇠 ", "【3-A】라고 적힌 낡은 열쇠. ", "녹이 슬어서 너덜너덜한데… ", " "),
			new CpItemData(66, 7, "鉄の釘抜き", "４のＡの教室で拾った、", "錆びついた鉄の釘(くぎ)抜き。", "", "Nail Puller", " Found in classroom 4-A. It's a", " plain, rusted nail puller made", " of iron.", "철제 못뽑이 ", "4-A 교실에서 주운 ", "녹이 슨 철제 못뽑이. ", " "),
			new CpItemData(190, 37, "新聞", "繭の持っていた古い新聞。「児童四名", "連続誘拐・殺人事件」被害者の写真を", "掲載。", "Newspaper", " An old newspaper clipping given by", " Mayu. Contains a photograph of the", " four kidnapping/murder victims.", "신문 ", "마유가 갖고 있던 낡은 신문. ", "「아동 4명 연속 유괴･살해 사건」 ", "피해자의 사진을 게재. "),
			new CpItemData(103, 38, "文化人形（頭）", "すすけた古い文化人形の首。", "", "", "Antique Doll (Head)", " An old, stained head from an", " antique Japanese festival doll.", " ", "문화인형 (머리) ", "때가 찌든 낡은 문화인형의 머리. ", " ", " "),
			new CpItemData(102, 39, "文化人形（体）", "すすけた古い文化人形の体。", "", "", "Antique Doll (Body)", " An old, stained torso from an", " antique Japanese festival doll.", " ", "문화인형 (몸) ", "때가 찌든 낡은 문화인형의 몸. ", " ", " "),
			new CpItemData(192, 8, "懺悔の心", "首と胴の揃った文化人形にこもった", "懺悔の心。", "", "Penitent Spirit", " An antique festival doll bearing", " the spirit of a man with a guilty", " conscience.", "참회의 마음 ", "머리와 몸이 붙은 문화인형에 담긴 ", " ", " "),
			new CpItemData(0, 0, "", "", "", "", "", "", "", "", " ", " ", " ", " ")
		};

		public static CpItemData[] cap3item = new CpItemData[10]
		{
			new CpItemData(165, 0, "ボロの板切れ", "見るからに脆そうな大きめの板切れ。", "人が乗るには適さないように見える。", "", "Loose Board", " A large, thin floorboard with an", " unsettling amount of give. Seems", " a bit sketchy to use.", "낡은 널빤지 ", "언뜻 보기에 약해보이는 커다란 널빤지. ", "사람이 올라타기에는 적합하지 않아 보인다. ", " "),
			new CpItemData(166, 9, "由香のお守り", "由香の宝物。危険から身を守って", "くれるという（？）お守り。", "中等部で流行っているらしい。", "Scented Beads", " Yuka's charm of protection (?).", " Seems to be all the rage these", " days in the junior high.", "유카의 부적 ", "유카의 보물. 위험으로부터 ", "몸을 지켜주는(?) 부적. ", "중등부에서 유행인 모양이다. "),
			new CpItemData(168, 1, "用途不明の鍵", "茶色く錆びてぼろぼろの鍵。", "ラベルのようなシールが貼ってあるが、", "そこも酸化しており判別が出来ない。", "Unknown Key", " A rusty brown key. Has a label on", " it, but oxidation has made it", " completely illegible.", "용도를 알 수 없는 열쇠 ", "누렇게 녹이 슨 낡은 열쇠. ", "라벨 같은 스티커가 붙어 있지만 ", "색이 바래서 판별하기 어렵다. "),
			new CpItemData(167, 7, "鉄の釘抜き", "本館２階の廊下で拾った、", "錆びついた鉄の釘(くぎ)抜き。", "", "Nail Puller", " Picked up in the 2F hallway. It's", " a plain, rusted nail puller made", " of iron.", "철제 못뽑이 ", "본관 2층 복도에서 주운 ", "녹이 슨 철제 못뽑이. ", " "),
			new CpItemData(169, 18, "ちいさな鍵", "１のＡの教室の棚から取り出した、", "金色の鍵。特殊な形をしている。", "", "Tiny Key", " Found in a cabinet in classroom", " 1-A. Has a golden sheen and a very", " distinctive shape.", "작은 열쇠 ", "1-A 교실 수납장에서 꺼낸 금색 열쇠. ", "특수한 모양새다. ", " "),
			new CpItemData(171, 11, "魔除けの靴", "霊能師により聖水のふられた靴。", "履いて手を繋げば、その場にいる", "全員が霊力の保護を受ける。", "Blessed Shoes", " Shoes blessed with holy water.", " Grant protection to their wearer", " and all who take his/her hands.", "액막이 신발 ", "영능사가 성수를 뿌린 신발. ", "이것을 신고 손을 잡으면, 그 자리에 있는 ", "전원이 영력의 보호를 받게 된다. "),
			new CpItemData(170, 12, "封印破りの水晶塊", "中に不思議な光を宿した、", "透明な水晶塊。", "", "Crystal of Unsealing", " A translucent crystal that shines", " with a mysterious light.", " ", "봉인해제 수정괴 ", "안에 불가사의한 빛이 깃든 ", "투명한 수정괴. ", " "),
			new CpItemData(225, 0, "ボロの板切れ", "見るからに脆そうな大きめの板切れ。", "人が乗るには適さないように見える。", "", "Loose Board", " A large, thin floorboard with an", " unsettling amount of give. Seems", " a bit sketchy to use.", "낡은 널빤지 ", "언뜻 보기에 약해보이는 커다란 널빤지. ", "사람이 올라타기에는 적합하지 않아 보인다. ", " "),
			new CpItemData(228, 13, "miniＤＶテープ①", "ラベルには、鬼碑忌\u3000取材①", "2005 11 19\u3000と書いてある。", "", "Mini-DV Tape", " The label reads:", " Kibiki Research Data 1", " 2005-11-19", "mini DV 테이프① ", "라벨에는 키비키 취재① ", "2005 11 19 라고 적혀 있다. ", " "),
			new CpItemData(0, 0, "", "", "", "", "", "", "", "", " ", " ", " ", " ")
		};

		public static CpItemData[] cap4item = new CpItemData[12]
		{
			new CpItemData(141, 13, "miniＤＶテープ①", "ラベルには、鬼碑忌\u3000取材①", "2005 11 19\u3000と書いてある。", "", "Mini-DV Tape", " The label reads:", " Kibiki Research Data 1", " 2005-11-19", "mini DV 테이프① ", "라벨에는 키비키 취재① ", "2005 11 19 라고 적혀 있다. ", " "),
			new CpItemData(139, 15, "世以子の携帯", "用務員室前で拾った世以子の携帯電話。", "メール作成中に落とされた様で、読む", "気は無かったがつい読んでしまった。", "Seiko's Cell Phone", " Found in the hallway. Seems Seiko", " was writing a text message to", " Naomi when she dropped it.", "세이코의 휴대전화 ", "수위실 앞에서 주운 세이코의 휴대전화. ", "문자를 적다가 떨어뜨린 모양이다. ", "내용을 볼 생각은 없었지만 보고 말았다. "),
			new CpItemData(140, 14, "直美の携帯", "普段教室で見慣れた、直美の携帯。", "世以子といつもメールを交換して遊ん", "でいたのが思い出される。", "Naomi's Cell Phone", " Naomi always used this to text", " with Seiko during class. Seems", " like such a distant memory now...", "나오미의 휴대전화 ", "평소 교실에서 보던, 나오미의 휴대전화. ", "언제나 세이코와 문자를 보내며 ", "놀던 게 생각난다. "),
			new CpItemData(130, 16, "遺体の一部（男児）", "小さな麻袋に入った『児童殺害事件』", "被害者の遺体の一部。持ち主に返す事", "が出来るのだろうか。", "Ryou's Tongue", " The severed tongue of one of the", " Heavenly Host murder victims,", " sealed in a small hemp bag.", "유해의 일부 (남아) ", "작은 마대 자루 안에 있는 ", "『아동 살해 사건』 피해자의 일부. ", "주인에게 돌려줄 수 있을까. "),
			new CpItemData(144, 8, "呪われた文化人形", "児童殺害犯の遺品。犯人の亡骸を捜す", "手掛かりになるかも知れない。", "", "Cursed Doll", " A relic that once belonged to the", " murderer. May prove invaluable in", " finding his victims' remains.", "저주받은 문화인형 ", "아동 살해범의 유품. 범인의 유해를 찾는 ", "단서가 될지도 모른다. ", " "),
			new CpItemData(138, 17, "用務員室の鍵", "『用務員室』とラベルのついた、", "血のように真っ赤な鍵。", "", "Custodian's Key", " A blood-red key labeled,", " ”Custodian's Closet.”", " ", "수위실 열쇠 ", "『수위실』이란 라벨이 붙은 ", "피처럼 새빨간 열쇠. ", " "),
			new CpItemData(131, 16, "遺体の一部（女児１）", "小さな麻袋に入った、『児童殺害事件』", "被害者の遺体の一部。持ち主に返す事", "が出来るのだろうか。", "Tokiko's Tongue", " The severed tongue of one of the", " Heavenly Host murder victims,", " sealed in a small hemp bag.", "유해의 일부 (여아1) ", "작은 마대 자루 안에 있는 ", "『아동 살해 사건』 피해자의 일부. ", "주인에게 돌려줄 수 있을까. "),
			new CpItemData(132, 16, "遺体の一部（女児２）", "小さな麻袋に入った、『児童殺害事件』", "被害者の遺体の一部。持ち主に返す事", "が出来るのだろうか。", "Yuki's Tongue", " The severed tongue of one of the", " Heavenly Host murder victims,", " sealed in a small hemp bag.", "유해의 일부 (여아2) ", "작은 마대 자루 안에 있는 ", "『아동 살해 사건』 피해자의 일부. ", "주인에게 돌려줄 수 있을까. "),
			new CpItemData(142, 18, "小さな鍵", "床下から良樹が拾い上げた小さなキー。", "時計のネジのような形をしている。", "", "Winder", " A tiny key shaped like the winder", " for a clock or music box.", " ", " 작은 열쇠", "요시키가 바닥 아래에 있던 것을 주워 올린 ", "작은 키. 시계의 나사 모양이다. ", " "),
			new CpItemData(143, 20, "錆びたハンドル", "プールの底に沈んでいた、", "何かの機械のハンドル。排水の際に", "排水口の中に流れ込んだようだ。", "Rusted Valve Wheel", " Found at the bottom of the pool.", " Probably got sucked in when the", " water was drained.", "녹슨 핸들 ", "수영장 바닥에 잠겨 있던 ", "어떤 기계의 핸들. 배수를 할 때 ", "배수구 안으로 흘러들어 갔던 모양이다. "),
			new CpItemData(223, 19, "水圧調整室の鍵", "プールサイドで拾った鍵。", "錆び付いて脆くなっており、", "一度使うと折れてしまいそうだ…", "Pump Room Key", " Found near the pool. It's thin,", " flimsy and rusted. Will probably", " break after a single use.", "수압조정실 열쇠 ", "수영장에서 주운 열쇠. ", "녹이 슬어서 한 번 쓰면 부러질 것 같다... ", " "),
			new CpItemData(0, 0, "", "", "", "", "", "", "", "", " ", " ", " ", " ")
		};

		public static CpItemData[] cap5item = new CpItemData[14]
		{
			new CpItemData(200, 21, "大理石の彫像", "悪魔のような造形の大理石の像。", "雪に渡された。", "", "Marble Statue", " A marble statue shaped like some", " sort of demon. Given to you by", " Yuki.", "대리석 조각상 ", "악마 같은 조형의 대리석 조각상. ", " 유키가 줬다.", " "),
			new CpItemData(201, 22, "直美の学生証", "直美の学生証。", "中には「幸せのサチコさん」の", "切れ端も挟まっている。", "Naomi's Student ID", " Naomi's student ID name tag. She", " must have dropped it along the way", " without even realizing it.", "나오미의 학생증 ", "나오미의 학생증. ", "안에는 「행복을 부르는 사치코씨」 ", "조각이 끼어 있다. "),
			new CpItemData(80, 24, "七星の手帳", "七星の取材用手帳。", "可愛くデコってあるが、書いてある", "ことは、結構怖い。", "Naho's Notebook", " Surprisingly cute. Stands in", " stark contrast to the information", " contained within.", "나호의 수첩 ", "나호의 취재용 수첩. ", "귀엽게 장식되어 있지만 ", "적혀 있는 내용은 매우 무섭다. "),
			new CpItemData(203, 28, "赤子の像", "たい児のような形状の像。霊物質が", "付着しており、表面はヌメヌメして", "いる。", "Baby Statue", " A statue shaped like an unborn", " baby in the womb. Covered in a", " thin film of ectoplasmic residue.", "갓난아기 상 ", "태아처럼 생긴 상. ", "영물질이 부착되어 있어 ", "표면이 매끈매끈하다. "),
			new CpItemData(205, 32, "サチコの舌", "校長の机から出てきたサチコの舌。", "", "", "Sachiko's Tongue", " Sachiko's tongue, enclosed in a", " hemp bag. Extracted from a desk", " drawer in the principal's office.", "사치코의 혀 ", "교장의 책상에서 나온 사치코의 혀. ", " ", " "),
			new CpItemData(92, 26, "miniDVテープ②", "鬼碑忌の取材テープその２。", "カセットには血が付着している。", "", "Mini-DV Tape 2", " Another Kibiki research tape,", " spattered liberally with blood.", " ", "mini DV 테이프② ", "키비키의 취재 테이프 그 2번째. ", "카세트에는 피가 묻어 있다. ", " "),
			new CpItemData(116, 30, "黒猫のぬいぐるみ", "ヨシヱがサチコの誕生日に贈った", "黒猫のぬいぐるみ。", "", "Black Cat Plushie", " A plushie purchased by Yoshie for", " Sachiko's birthday. Literally", " coming apart at the seams.", "검은고양이 인형 ", "요시에가 사치코에게 생일 선물로 준 ", "검은고양이 인형. ", " "),
			new CpItemData(57, 23, "由香の靴", "由香の上履き。表面には血が付着", "している。", "", "Yuka's Shoes", " Spattered with blood all along", " their edges...", " ", "유카의 신발 ", "유카의 실내화. ", "표면에는 피가 묻어 있다. ", " "),
			new CpItemData(175, 10, "玄関の鍵", "別館玄関の扉を開ける鍵。", "何者かが鍵をかけ、この鍵を", "隠したようだ。", "Building Key", " The key to the only exit from the", " second wing. Someone must've hidden", " this after locking the door.", "현관 열쇠 ", "별관 현관문을 열 수 있는 열쇠. ", "누군가가 문을 잠그고 ", "이 열쇠를 숨긴 모양이다. "),
			new CpItemData(204, 31, "校長室の鍵", "ストラップのついた小さな鍵。天神小", "校長の飛び降り死体から転げ出たもの。", "", "Principal's Key", " A key attached to a gourd-shaped", " keychain. Found on the body of", " Principal Takamine Yanagihori.", "교장실 열쇠 ", "스트랩이 달린 작은 열쇠. ", "텐진초 교장이 추락한 사체에서 나온 것. ", " "),
			new CpItemData(219, 27, "miniDVテープ【罪】", "ラベルに「罪」と書かれた、血塗れの", "miniDVテープ。由香が棚から見つけた。", "", "Mini-DV ”Sin” Tape", " Found on a shelf by Yuka. The", " label just says, ”Sin.” Spattered", " with copious amounts of blood.", "mini DV 테이프【죄】 ", "라벨에 「죄」라고 적힌 피투성이 테이프. ", "수납장 안에 있던 것을 유카가 찾아냈다. ", " "),
			new CpItemData(228, 2, "理科室の鍵", "理科室の中で見つけた鍵。", "刻命が持っていたはずだが……", "", "Lab Key", " A key found in the science lab.", " Didn't Kizami have this last...?", " ", "과학실 열쇠 ", "과학실 안에서 찾은 열쇠. ", "키자미가 가지고 있었는데...... ", " "),
			new CpItemData(198, 25, "森繁の携帯", "血塗れになった森繁の携帯。", "森繁最後の様子が動画として残って", "いるのは、果たして偶然か？", "Morishige's Cell Phone", " Morishige's bloodied cell phone.", " How is it that his final moments", " were recorded in video...?", "모리시게의 휴대전화 ", "피투성이가 된 모리시게의 휴대전화. ", "모리시게의 최후가 영상으로 남겨진 건 ", "정말 우연일까? "),
			new CpItemData(0, 0, "", "", "", "", "", "", "", "", " ", " ", " ", " ")
		};

		public static CpItemData[] capex1item = new CpItemData[6]
		{
			new CpItemData(51, 33, "千早のポーチ", "ピンク色の、千早のポーチ。", "可愛い ねこの絵が描いてある。", "", "Chihaya's Pouch", " Chihaya's adorable pink pouch.", " Decorated with a cute little kitty", " cat and a short musical phrase.", "치하야의 파우치 ", "치하야의 핑크색 파우치. ", "귀여운 고양이가 그려져 있다. ", " "),
			new CpItemData(63, 34, "星型“PEACE”サングラス", "上級者向け。", "ドレッドヘアーにとても似合う。", "", "Superstar Sunglasses", " For people with discriminating", " taste. They go well with", " dreadlocks.", "별모양 “PEACE\" 선글라스 ", "상급자용. ", "드레드 헤어에 매우 잘 어울린다. ", " "),
			new CpItemData(68, 35, "エレガントな眼鏡", "フレームの薄い、デザイン性に優れた", "眼鏡。", "これも上級者向け。", "Distinguished Glasses", " A thin frame and sophisticated", " lines cap off these high quality,", " high-end designer glasses.", "고상한 안경 ", "프레임이 얇고, 디자인이 우수한 안경. ", "이것도 상급자용. ", " "),
			new CpItemData(73, 2, "保健室の鍵", "【保健室】と書かれたシールの上に", "セロハンテープで補強された鍵。", "赤い魂から奪い取った。", "Infirmary Key", " A small piece of paper taped onto", " the head of this key reads,", "” Infirmary.”", "보건실 열쇠 ", "【보건실】이라고 적힌 스티커 위에 ", "셀로판 테이프를 붙인 열쇠. ", "빨간 혼이 갖고 있던 것을 빼앗았다. "),
			new CpItemData(77, 36, "ソフト帽", "シルクリボンの巻かれた、イタリアン", "スタイルの高級フェルトハット。", "", "Felt Hat", " An expensive-looking Italian-style", " felt hat decorated with a silk", " ribbon.", "소프트 모자 ", "실크 리본이 달린 ", "이탈리안 스타일의 고급 펠트 햇. ", " "),
			new CpItemData(0, 0, "", "", "", "", "", "", "", "", " ", " ", " ", " ")
		};

		public static CpItemData[] capex2item = new CpItemData[2]
		{
			new CpItemData(245, 40, "携帯電話", "森繁私物の携帯電話。", "天神小で沢山撮った死体の写真が", "詰まっている……。", "Morishige's Cell Phone", " Morishige's bloodied cell phone.", " How is it that his final moments", " were recorded in video...?", "휴대전화 ", "모리시게의 휴대전화. ", "텐진초에서 찍은 사체 사진이 ", "잔뜩 들어 있다...... "),
			new CpItemData(0, 0, "", "", "", "", "", "", "", "", " ", " ", " ", " ")
		};

		public static CpItemData[] capex31item = new CpItemData[3]
		{
			new CpItemData(220, 0, "ボロの板切れ", "見るからに脆そうな、大きめの板切れ。", "すこし欠けて短くなっている。", "", "Loose Board", " A large, brittle-looking plank of wood.", " Shorter now that a piece of it has broken off.", " ", "허름한\u00a0널조각 ", "보기만\u00a0해도\u00a0단단하지\u00a0않은\u00a0널조각. ", " ", " "),
			new CpItemData(221, 41, "涼香の学生証", "涼香の学生証。", "証明写真でさえも", "すごく可愛らしく撮れている。", "Ryoka's Student ID", " Ryoka's student ID.", " Even her picture looks", " absolutely adorable.", "료코의 학생증 ", "료코의 학생증.  ", "증면사진 마저도 ", "너무나 귀엽게 나와 있습니다. "),
			new CpItemData(0, 0, "", "", "", "", "", "", "", "", " ", " ", " ", " ")
		};
	}
}
