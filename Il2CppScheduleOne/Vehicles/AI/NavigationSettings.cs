using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020004FD RID: 1277
	public class NavigationSettings : Object
	{
		// Token: 0x060070C3 RID: 28867 RVA: 0x001EF560 File Offset: 0x001ED760
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationSettings()
		{
			Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "NavigationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr);
			NavigationSettings.NativeFieldInfoPtr_endAtRoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "endAtRoad");
			NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "ensureProximityToGraph");
			NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "teleportToGraphIfCalculationFails");
			NavigationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, 100677458);
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x001EF5E0 File Offset: 0x001ED7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221712, XrefRangeEnd = 221713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070C5 RID: 28869 RVA: 0x000358D6 File Offset: 0x00033AD6
		public NavigationSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x060070C6 RID: 28870 RVA: 0x001EF61C File Offset: 0x001ED81C
		// (set) Token: 0x060070C7 RID: 28871 RVA: 0x000358DF File Offset: 0x00033ADF
		public unsafe bool endAtRoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_endAtRoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_endAtRoad)) = value;
			}
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x060070C8 RID: 28872 RVA: 0x001EF644 File Offset: 0x001ED844
		// (set) Token: 0x060070C9 RID: 28873 RVA: 0x000358FA File Offset: 0x00033AFA
		public unsafe bool ensureProximityToGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph)) = value;
			}
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x060070CA RID: 28874 RVA: 0x001EF66C File Offset: 0x001ED86C
		// (set) Token: 0x060070CB RID: 28875 RVA: 0x00035915 File Offset: 0x00033B15
		public unsafe bool teleportToGraphIfCalculationFails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails)) = value;
			}
		}

		// Token: 0x04004D0B RID: 19723
		private static readonly IntPtr NativeFieldInfoPtr_endAtRoad;

		// Token: 0x04004D0C RID: 19724
		private static readonly IntPtr NativeFieldInfoPtr_ensureProximityToGraph;

		// Token: 0x04004D0D RID: 19725
		private static readonly IntPtr NativeFieldInfoPtr_teleportToGraphIfCalculationFails;

		// Token: 0x04004D0E RID: 19726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
