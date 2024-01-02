קייטרינג
תאור הפרויקט:
מערכת לניהול הזמנת מנות מוכנות לאירועים ושבתות
ישויות:
מנה בתפריט: קוד, מחיר, תיאור, תוספת?
לקוח: קוד, שם, טלפון, כתובת, רשימת הזמנות קודמות
הזמנה: קוד, רשימת מאכלים, כמות, משלוח?, מחיר סופי

 ללקוחות Routes מיפוי
שליפת רשימת הלקוחות
GET https://catering.co.il/customers
שליפת לקוח לפי מזהה
GET https:// catering.co.il/ customers /1
הוספת לקוח
POST https:// catering.co.il/ customers 
עדכון לקוח
PUT https:// catering.co.il/ customers /1


למאכלים Routes מיפוי 
שליפת רשימת המאכלים
GET https:// catering.co.il/dishes
שליפת מאכל לפי מזהה
GET https:// catering.co.il/ dishes /1
שליפת מאכלים עד מחיר מסוים
GET https:// catering.co.il/ dishes /price/120

הוספת מאכל
POST https:// catering.co.il/ dishes 
עדכון מאכל
PUT https:// catering.co.il/ dishes /1
מחיקת מאכל
DELETE https:// catering.co.il/ dishes /1

להזמנות Routes מיפוי 
שליפת רשימת ההזמנות
GET https:// catering.co.il/orders
שליפת הזמנה לפי מזהה
GET https:// catering.co.il/ orders /1
שליפת הזמנה לפי לקוח
GET https:// catering.co.il/ orders /customer/1

הוספת הזמנה
POST https:// catering.co.il/ dishes 
עדכון הזמנה
PUT https:// catering.co.il/ dishes /1

עדכון משלוח הזמנה
PUT https:// catering.co.il/ dishes/1/isSending

מחיקת מאכל
DELETE https:// catering.co.il/ dishes /1
