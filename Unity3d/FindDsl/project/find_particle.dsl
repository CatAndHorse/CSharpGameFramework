input("*.prefab")
{
	int("maxSize",10);
	string("filter", "");
	feature("source", "project");
	feature("menu", "1.Project Resources/Particle Systems");
	feature("description", "just so so");
}
filter
{
	object = loadasset(assetpath);
	var(0) = getcomponentsinchildren(object,"ParticleSystem");
	var(1) = var(0).Length;
	order = var(1);
	if(var(1)>maxSize && assetpath.Contains(filter)){
	  info = "粒子系统数量："+var(1);
		1;
	}else{
		0;
	};
};