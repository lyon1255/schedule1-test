using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000284 RID: 644
	[Serializable]
	public class RouteListData : Object
	{
		// Token: 0x06002FE5 RID: 12261 RVA: 0x00108CFC File Offset: 0x00106EFC
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListData()
		{
			Il2CppClassPointerStore<RouteListData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "RouteListData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListData>.NativeClassPtr);
			RouteListData.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListData>.NativeClassPtr, "Routes");
			RouteListData.NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListData>.NativeClassPtr, 100668792);
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00108D54 File Offset: 0x00106F54
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17915, RefRangeEnd = 18092, XrefRangeStart = 17915, XrefRangeEnd = 18092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListData(List<AdvancedTransitRouteData> routes) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(routes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListData.NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x0001963F File Offset: 0x0001783F
		public RouteListData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x00108DA0 File Offset: 0x00106FA0
		// (set) Token: 0x06002FE9 RID: 12265 RVA: 0x00019648 File Offset: 0x00017848
		public unsafe List<AdvancedTransitRouteData> Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListData.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdvancedTransitRouteData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListData.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0;
	}
}
