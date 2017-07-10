#encoding "utf8"
Day->AnyWord<wff = / ([1 - 2] ? [0 - 9]) | (3[0 - 1]) / >; // число от 1 до 31
Month->Noun<kwtype = "месяц">;                // используем слова из статьи "месяц"
YearDescr -> "год" | "г. ";
Year->AnyWord<wff = / [1 - 2] ? [0 - 9]{ 1,3 }г ? \. ? / >; // число от 0 до 2999 с возможным "г" или "г." в конце
Year->Year YearDescr;

// число, месяц и год: "10 января 2011"
Date->Day interp(Fact.Field1)
Month interp(Fact.Field2)
(Year interp(Fact.Field3));

// месяц и год: "июнь 2009"
Date->Month interp(Fact.Field2)
Year interp(Fact.Field3);