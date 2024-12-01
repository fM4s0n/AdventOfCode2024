﻿namespace AdventOfCode2024.DaySolutions;

internal static class Day1
{
    private const string input = "49744   57964\r\n20738   85861\r\n20319   65072\r\n79568   74248\r\n78194   83454\r\n48701   94102\r\n69552   26808\r\n62781   67392\r\n85323   47428\r\n99344   72568\r\n27523   97243\r\n48039   36600\r\n91532   31571\r\n21306   31571\r\n52409   10805\r\n33901   31571\r\n80772   38756\r\n13849   54584\r\n72294   28326\r\n86065   65553\r\n93987   72533\r\n81640   39741\r\n25701   89912\r\n98611   57082\r\n80949   94974\r\n84717   61876\r\n31599   57082\r\n87119   65871\r\n56659   22897\r\n60864   45613\r\n64914   23217\r\n41931   23325\r\n13675   56060\r\n85486   66429\r\n99589   34428\r\n80942   50436\r\n66446   27795\r\n62260   94102\r\n17991   95754\r\n38666   94018\r\n82715   65319\r\n96748   95959\r\n76620   75639\r\n39724   86975\r\n83462   61805\r\n80757   66429\r\n80161   66912\r\n27338   97381\r\n29349   58983\r\n19921   95959\r\n33222   95959\r\n29944   13408\r\n33806   85400\r\n70346   93552\r\n62146   56773\r\n29455   80011\r\n13072   39741\r\n78082   85362\r\n68244   22897\r\n92699   85216\r\n77401   20843\r\n53297   82515\r\n47145   90966\r\n21714   83969\r\n38897   81770\r\n26583   96472\r\n33538   94102\r\n50607   51437\r\n29920   18034\r\n86162   28326\r\n20887   26374\r\n70011   95959\r\n91072   33837\r\n78041   78550\r\n36971   96504\r\n93552   45613\r\n35166   39027\r\n55765   21306\r\n62548   27834\r\n25287   27430\r\n16941   92472\r\n92686   35418\r\n18196   61876\r\n98271   56773\r\n70197   57082\r\n60087   36019\r\n94691   57607\r\n71834   36600\r\n66838   72703\r\n99514   30035\r\n87478   37752\r\n31855   89828\r\n63670   55131\r\n96582   96472\r\n56506   28326\r\n22986   50890\r\n28459   76391\r\n81838   56060\r\n73857   57964\r\n65911   96472\r\n70631   78246\r\n35372   83680\r\n59537   53263\r\n69802   83656\r\n60922   95754\r\n98033   55131\r\n61192   56233\r\n10544   96472\r\n70076   96748\r\n10345   72533\r\n44069   59959\r\n51368   24943\r\n32209   94323\r\n93608   15236\r\n66052   18518\r\n18194   74248\r\n61876   60690\r\n38359   91941\r\n99648   94102\r\n26870   95959\r\n42700   22080\r\n60343   57082\r\n86403   63844\r\n68549   71668\r\n94395   31571\r\n54117   76136\r\n82957   91182\r\n76970   30786\r\n21467   96999\r\n63240   61876\r\n41407   52311\r\n79043   64533\r\n68714   18737\r\n88316   43212\r\n74330   56060\r\n95754   42389\r\n97007   15593\r\n23600   61876\r\n35794   37497\r\n51155   33837\r\n38878   57779\r\n88160   66923\r\n85960   15356\r\n19608   90678\r\n15335   19142\r\n37858   28326\r\n52362   61567\r\n92440   25615\r\n40806   68569\r\n71751   97177\r\n42549   70211\r\n97573   97882\r\n70977   72533\r\n82166   87204\r\n73168   45613\r\n33988   40287\r\n81017   24791\r\n97826   39494\r\n49366   57853\r\n58833   30509\r\n12049   99552\r\n44295   28655\r\n33286   86203\r\n68443   28326\r\n72269   59959\r\n56222   28326\r\n66315   57082\r\n76461   90360\r\n46531   28326\r\n63925   80949\r\n34114   91182\r\n81992   31571\r\n24536   11763\r\n22518   70755\r\n11355   31571\r\n31145   28326\r\n55129   17000\r\n17135   54266\r\n19316   57094\r\n63206   26374\r\n31039   57082\r\n20090   45613\r\n25633   34423\r\n95984   74248\r\n28231   31899\r\n79070   33837\r\n20608   10744\r\n31697   41568\r\n13523   99552\r\n44342   74248\r\n58138   66429\r\n53615   11293\r\n13400   99229\r\n44548   22051\r\n24137   37497\r\n30607   56348\r\n53530   14398\r\n44035   83213\r\n56874   38315\r\n79779   99487\r\n43670   58472\r\n18036   94582\r\n92084   36917\r\n95857   89269\r\n59178   48607\r\n77507   14389\r\n24249   94980\r\n68856   14162\r\n46913   13677\r\n77339   59959\r\n40867   94102\r\n20361   27399\r\n10126   40204\r\n56279   57964\r\n37924   33837\r\n35066   28326\r\n79906   33390\r\n77938   18925\r\n30427   74248\r\n49792   39885\r\n10401   72533\r\n27300   12967\r\n15461   66429\r\n86381   10670\r\n25350   72755\r\n79472   90026\r\n11038   78545\r\n31085   82018\r\n29807   94018\r\n50918   37018\r\n56092   21306\r\n18839   97675\r\n12995   26374\r\n89946   62988\r\n59719   56060\r\n23083   50209\r\n14050   77608\r\n61314   53662\r\n55468   87206\r\n32735   39741\r\n54600   91182\r\n15821   77607\r\n88847   22065\r\n99872   95959\r\n53375   22897\r\n35209   56060\r\n77630   91182\r\n96800   96472\r\n26264   66429\r\n35274   25151\r\n25538   61863\r\n23186   96504\r\n91734   39741\r\n91485   59959\r\n89103   36687\r\n78785   96472\r\n13949   65200\r\n44396   31571\r\n16507   29954\r\n65200   56352\r\n67353   98520\r\n44969   45613\r\n70144   10313\r\n52148   90071\r\n43359   21780\r\n83268   52625\r\n92052   42928\r\n56773   32010\r\n77013   33885\r\n83505   38104\r\n44966   20462\r\n30790   94102\r\n73511   57082\r\n17994   13777\r\n52046   31571\r\n71445   38756\r\n31099   57082\r\n96873   72533\r\n63090   47113\r\n39327   68753\r\n33913   60253\r\n38546   53200\r\n16726   29956\r\n86820   42850\r\n61083   38756\r\n40096   55131\r\n95004   23484\r\n17136   61958\r\n87117   80803\r\n44050   92626\r\n65352   22440\r\n13813   61876\r\n82994   99641\r\n16136   45613\r\n13490   56775\r\n51061   80949\r\n61335   91182\r\n52053   33837\r\n50455   45613\r\n50980   41238\r\n58258   38756\r\n52546   10801\r\n32924   50528\r\n98144   31571\r\n74993   37070\r\n27437   36600\r\n46078   69578\r\n35719   36796\r\n91307   66923\r\n82413   98969\r\n21224   59959\r\n95996   90116\r\n61607   33837\r\n71741   14132\r\n48452   79616\r\n16452   36600\r\n29032   22897\r\n68251   80913\r\n15226   83141\r\n82072   62781\r\n78732   39741\r\n26072   57964\r\n44560   96564\r\n57175   78034\r\n86181   64955\r\n70004   13437\r\n21403   13757\r\n25396   90508\r\n22388   52004\r\n70087   96504\r\n35852   65506\r\n16149   94963\r\n12499   33837\r\n49826   57082\r\n64984   29694\r\n84227   56060\r\n13306   60690\r\n74909   11772\r\n74115   55131\r\n82914   72533\r\n32578   19223\r\n30971   86868\r\n58566   24936\r\n68362   38756\r\n23665   66429\r\n45658   28326\r\n29325   66923\r\n11640   96472\r\n73355   95114\r\n87940   62631\r\n47689   53862\r\n80029   39694\r\n94261   66429\r\n84444   34312\r\n65441   62781\r\n93632   24791\r\n27259   60690\r\n52365   20133\r\n39145   29503\r\n54077   45613\r\n22106   78246\r\n21462   78868\r\n61680   96472\r\n87688   10794\r\n82919   85055\r\n70741   55416\r\n94102   45462\r\n20816   72533\r\n23126   80949\r\n46112   54307\r\n78700   91182\r\n37497   10418\r\n34307   96426\r\n32939   91637\r\n55698   73001\r\n28008   62824\r\n56695   66157\r\n45273   79240\r\n26479   62781\r\n17458   28326\r\n13240   96504\r\n49411   16963\r\n11293   40392\r\n59492   11248\r\n39242   18166\r\n82125   19380\r\n10425   43878\r\n96169   94102\r\n72148   96504\r\n98699   55131\r\n64519   52279\r\n75839   26129\r\n99109   35627\r\n52989   24557\r\n19839   39741\r\n33892   57082\r\n57138   34347\r\n85986   61876\r\n63721   30120\r\n11728   96504\r\n97643   59959\r\n75752   35597\r\n78681   70815\r\n69201   86837\r\n22897   33144\r\n84476   38522\r\n70192   39741\r\n11796   57964\r\n24791   38756\r\n91343   82170\r\n71121   29320\r\n19725   99552\r\n55131   37497\r\n10398   64652\r\n43837   57964\r\n96472   21420\r\n15661   66429\r\n73100   81872\r\n16347   66923\r\n78667   20821\r\n62503   62781\r\n55388   26374\r\n30709   66923\r\n34765   95959\r\n13082   29914\r\n92169   76512\r\n74594   92616\r\n74628   53874\r\n36549   25654\r\n35684   62381\r\n44535   36600\r\n41585   64032\r\n35820   21306\r\n48491   57082\r\n36868   56612\r\n24081   66429\r\n44738   69207\r\n14242   61270\r\n66040   86333\r\n38756   15652\r\n12973   93977\r\n39993   52251\r\n74626   27427\r\n50280   39741\r\n96839   54610\r\n80128   91182\r\n78847   59523\r\n91308   65211\r\n26341   26687\r\n53571   95959\r\n18687   95754\r\n61386   26984\r\n44578   56060\r\n21602   66294\r\n39402   19968\r\n98549   21306\r\n57082   57082\r\n95948   96472\r\n55751   28461\r\n42067   35169\r\n28553   27971\r\n47930   26374\r\n32007   43799\r\n52341   31491\r\n71093   55131\r\n74053   19526\r\n59959   96472\r\n34557   39741\r\n55998   56060\r\n22907   45181\r\n23079   95754\r\n40762   88028\r\n11191   58553\r\n37934   56923\r\n12082   85950\r\n61831   36600\r\n15330   24791\r\n70852   41905\r\n85973   56773\r\n34561   75129\r\n74529   78267\r\n39741   28059\r\n20706   21306\r\n80276   70751\r\n65709   56060\r\n36696   94102\r\n94364   28879\r\n20233   98589\r\n27112   80065\r\n99335   59959\r\n37076   91182\r\n92060   71029\r\n46294   42031\r\n25253   24610\r\n45857   89413\r\n41637   42336\r\n93798   61876\r\n17452   94018\r\n36934   23498\r\n22889   45613\r\n71786   91182\r\n40024   91182\r\n35594   69578\r\n46950   22480\r\n12379   31571\r\n16945   30582\r\n61614   68940\r\n48173   57082\r\n32624   58684\r\n94003   80949\r\n21551   72636\r\n49500   56060\r\n91508   20461\r\n71692   96504\r\n62379   94102\r\n70549   11293\r\n87238   54313\r\n16792   95243\r\n93509   41331\r\n72142   59959\r\n92474   76566\r\n53189   85632\r\n77138   56060\r\n41950   61876\r\n85591   40423\r\n78605   72026\r\n62515   87456\r\n49015   56060\r\n41423   77742\r\n47452   74248\r\n57647   66923\r\n21068   27043\r\n30120   95754\r\n95959   18741\r\n93197   61876\r\n80423   21650\r\n57729   71451\r\n29453   66923\r\n28326   87009\r\n46744   59056\r\n81115   66720\r\n38857   74550\r\n49849   70483\r\n55419   26374\r\n78335   45613\r\n60739   12508\r\n35968   17587\r\n18079   94018\r\n53376   80949\r\n41369   95754\r\n30754   14438\r\n81555   28326\r\n43955   41187\r\n38988   78246\r\n38187   67264\r\n99187   45613\r\n37551   21995\r\n13548   57964\r\n16827   72533\r\n43704   79494\r\n19039   36600\r\n70278   78246\r\n80016   22311\r\n62776   45613\r\n79357   33868\r\n64692   66923\r\n98491   42514\r\n88957   86978\r\n74622   57082\r\n47277   56060\r\n96504   53011\r\n87114   78246\r\n49142   68730\r\n92395   61876\r\n78246   45633\r\n11014   94102\r\n18985   48066\r\n76726   10822\r\n57367   77129\r\n28336   56773\r\n24092   42238\r\n25097   27558\r\n94664   68325\r\n51015   98113\r\n40965   69363\r\n89650   69743\r\n76254   54738\r\n69293   31098\r\n11002   43227\r\n60647   46055\r\n46338   97100\r\n36587   14512\r\n89640   96472\r\n27182   38982\r\n11523   54465\r\n33740   14458\r\n71700   78246\r\n85059   29940\r\n93168   61876\r\n96566   96501\r\n91222   94871\r\n62135   18552\r\n75319   24791\r\n14722   37543\r\n91216   59756\r\n58320   96504\r\n74828   99175\r\n11918   43162\r\n84262   30120\r\n47931   66308\r\n46840   94018\r\n24878   71006\r\n20196   36600\r\n20053   97794\r\n67727   36600\r\n97721   45613\r\n99910   96504\r\n51916   61876\r\n39198   39741\r\n15353   96472\r\n27494   83600\r\n52327   54203\r\n25445   55131\r\n29317   39741\r\n94384   10226\r\n19572   93557\r\n36386   44570\r\n31160   70870\r\n73783   84105\r\n54235   28326\r\n16618   66240\r\n16583   11293\r\n19080   91182\r\n57657   31571\r\n73272   48955\r\n69949   96472\r\n75895   89320\r\n41001   80919\r\n14825   57964\r\n94637   57010\r\n54556   56655\r\n33409   68761\r\n74248   68712\r\n25684   99655\r\n48181   63856\r\n69001   31571\r\n49706   36600\r\n54409   39741\r\n91718   66923\r\n31725   94777\r\n72533   27698\r\n45613   78246\r\n15604   87841\r\n32504   35779\r\n62179   62336\r\n72501   99090\r\n30561   39148\r\n79165   11307\r\n31571   65867\r\n13483   20228\r\n20894   89446\r\n23467   21201\r\n92291   55131\r\n94833   91236\r\n95658   91182\r\n51242   98018\r\n73738   62574\r\n30352   70801\r\n27292   17870\r\n86166   11293\r\n72308   61796\r\n73796   91182\r\n30666   96472\r\n13744   56060\r\n94746   69471\r\n15788   58248\r\n58081   78246\r\n23677   35070\r\n20968   28326\r\n56889   34484\r\n63353   66429\r\n12017   61948\r\n85307   52672\r\n59926   51517\r\n46647   55131\r\n99274   19268\r\n34708   21306\r\n26098   84160\r\n70078   45613\r\n86009   71606\r\n65008   57082\r\n19264   83154\r\n20880   46063\r\n80697   36600\r\n71856   52774\r\n62253   85982\r\n49783   95959\r\n46304   59716\r\n21948   61876\r\n96173   56060\r\n67970   65512\r\n29760   78254\r\n73066   97659\r\n77146   15368\r\n37411   79698\r\n13440   56060\r\n70769   48563\r\n24345   24307\r\n38871   96472\r\n34643   39899\r\n85582   97868\r\n48894   61876\r\n94213   97721\r\n18933   96472\r\n92678   95736\r\n53120   96472\r\n64527   96472\r\n10371   78098\r\n59311   88758\r\n44618   56981\r\n86901   37114\r\n90476   91182\r\n49214   45967\r\n12902   22940\r\n77674   19791\r\n58536   54989\r\n55151   95959\r\n62585   59296\r\n79446   91182\r\n42137   48087\r\n12461   44870\r\n19364   33837\r\n45512   71150\r\n68482   71531\r\n85801   78226\r\n27769   65652\r\n88199   81929\r\n99552   96748\r\n20141   61876\r\n22666   66429\r\n86571   85514\r\n20972   66429\r\n67365   28326\r\n96745   70447\r\n30339   62505\r\n64329   57964\r\n96535   26191\r\n61214   94102\r\n41068   82628\r\n54705   78246\r\n58853   31571\r\n80242   63529\r\n50060   57572\r\n47480   28326\r\n12425   61026\r\n44531   87545\r\n70463   50053\r\n62417   21306\r\n41173   74875\r\n72821   50395\r\n27947   96504\r\n15054   26374\r\n42867   16834\r\n71107   61876\r\n21999   91182\r\n87293   66292\r\n57292   53687\r\n89185   22897\r\n66923   23550\r\n57480   56060\r\n92097   56060\r\n97667   72991\r\n50851   86690\r\n92405   36161\r\n22888   94102\r\n86556   28570\r\n62406   11574\r\n17094   66429\r\n62672   56060\r\n27924   30120\r\n82298   32659\r\n89119   59959\r\n74159   69406\r\n69593   78246\r\n88983   83908\r\n93972   83391\r\n36585   57082\r\n52166   66923\r\n62447   95959\r\n94429   39880\r\n41624   54107\r\n14949   64308\r\n51582   28326\r\n54462   81726\r\n92666   64896\r\n73886   38756\r\n95390   57082\r\n75706   87003\r\n72752   95754\r\n96156   59816\r\n35797   31571\r\n76304   62517\r\n17302   56078\r\n29863   45613\r\n71018   41031\r\n79393   96504\r\n39665   84870\r\n59897   28326\r\n19583   89861\r\n39734   55131\r\n54048   21306\r\n53737   36600\r\n25787   92176\r\n68097   38864\r\n84659   35639\r\n66422   78246\r\n61057   77596\r\n26983   33837\r\n78620   95754\r\n75994   96472\r\n91182   31571\r\n39465   99552\r\n31512   64487\r\n67267   99879\r\n92670   61876\r\n88963   12495\r\n69591   74404\r\n34360   95959\r\n21342   51751\r\n48368   68547\r\n84355   71495\r\n72598   13991\r\n25399   75100\r\n77633   38756\r\n12872   67701\r\n12911   13630\r\n67871   17769\r\n79299   23907\r\n62490   28214\r\n71363   26374\r\n42174   86827\r\n23543   18277\r\n33152   73936\r\n60595   25272\r\n76463   38756\r\n53592   83420\r\n66429   78246\r\n25297   19454\r\n48577   57964\r\n42304   14722\r\n93639   89903\r\n42775   71581\r\n50460   11293\r\n29524   80109\r\n46795   40266\r\n79152   53926\r\n14530   61876\r\n68493   26374\r\n24568   82687\r\n60047   93799\r\n16856   57484\r\n11257   55131\r\n45834   91182\r\n67239   99552\r\n90933   31571\r\n82510   39741\r\n41567   57964\r\n67771   12794\r\n51836   23333\r\n24272   34097\r\n98163   78032\r\n42341   28326\r\n99975   50627\r\n86706   78246\r\n63008   57082\r\n33127   94102\r\n56060   74408\r\n37624   19600\r\n17196   46856\r\n77494   29078\r\n31050   30252\r\n30922   68664\r\n13399   24791\r\n54645   94102\r\n62173   56060\r\n62597   95959\r\n25348   95754\r\n60690   34683\r\n58377   92313\r\n38765   91182\r\n59869   59959\r\n95782   21975\r\n43833   24559\r\n57964   47902\r\n79937   22798\r\n35657   99552\r\n38354   39741\r\n91373   32691\r\n28546   23562\r\n38067   66077\r\n60370   39741\r\n36600   80189\r\n92953   61431\r\n43812   69640\r\n28600   26374\r\n56239   94102\r\n88573   99863\r\n23117   99552\r\n18732   74248\r\n39600   31571\r\n73867   53714\r\n77524   95959\r\n45578   26950\r\n46821   36659\r\n62249   97476\r\n29888   99552\r\n54493   57468\r\n25883   29690\r\n53727   55505\r\n28962   11293\r\n89727   11115\r\n60204   26859\r\n27607   66429\r\n54053   36600\r\n78805   13083\r\n27832   94102\r\n69578   72533\r\n13366   66923\r\n50257   80949\r\n61725   12887\r\n74296   39275\r\n49595   45613\r\n68879   79435\r\n30887   31571\r\n77646   40579\r\n55065   95754\r\n71461   55131\r\n20455   25666\r\n15976   96504\r\n44244   94102\r\n19368   33837\r\n66895   59959\r\n63579   38775\r\n25319   62695\r\n65478   38944\r\n98576   88366\r\n30591   88848\r\n92278   26374\r\n11161   26374\r\n24787   86464\r\n32547   93818\r\n34401   44410\r\n19631   47153\r\n97521   48956\r\n42475   28326\r\n45770   33837\r\n96953   52782\r\n77277   99552\r\n21192   30120\r\n96102   49059\r\n83877   99552\r\n43843   83930\r\n94704   36600\r\n33068   36600\r\n32295   53884\r\n14212   29797\r\n26374   58819\r\n72056   90078\r\n33837   93677\r\n74749   31723\r\n84678   57082\r\n37631   96472\r\n89434   61876\r\n41106   91182\r\n67810   18348\r\n52560   97721\r\n28995   54202\r\n17694   42638\r\n19388   36600\r\n19607   66429\r\n63536   12795\r\n43226   10644\r\n85270   81984\r\n11781   38756\r\n59217   36600\r\n20981   73723\r\n41651   66429\r\n51009   19419\r\n27331   64134\r\n52422   83283\r\n60900   21538\r\n40218   49769\r\n46711   48222\r\n47987   33837\r\n41207   70442\r\n47097   45613\r\n77564   99991\r\n94018   96504\r\n74639   32409\r\n56126   28988";
    private const string testInput = "3   4\r\n4   3\r\n2   5\r\n1   3\r\n3   9\r\n3   3";

    public static int Part1()
    {
        int total = 0;

        var lines = input.Split("\r\n");

        var leftList = new List<int>();
        var rightList = new List<int>();

        foreach (string line in lines)
        {
            var nums = line.Split("   ");

            leftList.Add(Convert.ToInt32(nums[0]));
            rightList.Add(Convert.ToInt32(nums[1]));
        }

        leftList.Sort();
        rightList.Sort();

        for (int i = 0; i < leftList.Count; i++)
        {
            int diff = rightList[i] - leftList[i];

            if (diff < 0)
            {
                diff *= -1;
            }

            total += diff;
        }

        return total;
    }

    public static int Part2()
    {
        int total = 0;
        var lines = input.Split("\r\n");
        var leftList = new List<int>();
        var rightList = new List<int>();

        foreach (string line in lines) 
        {
            var nums = line.Split("   ");
            leftList.Add(Convert.ToInt32(nums[0]));
            rightList.Add(Convert.ToInt32(nums[1]));
        }

        foreach (int leftNum in leftList)
        {
            int rightListOccurances = rightList.Count(x => x == leftNum);
            int similarityScore = leftNum * rightListOccurances;
            total += similarityScore;
        }

        return total;
    }
}
