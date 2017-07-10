#encoding "utf-8"
// ищет у кого обедал воробей
Animal->Noun<kwtype = animal>;
WithWho -> 'у' (Adj<gnc - agr[1]>) Animal<gram = 'род', rt, gnc - agr[1]> interp(Fact.Field1);
WithWho -> 'с' (Adj<gnc - agr[1]>) Animal<gram = 'твор', rt, gnc - agr[1]> interp(Fact.Field1);

