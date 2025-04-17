using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000271 RID: 625
	[Serializable]
	public class AdvancedTransitRouteData : Object
	{
		// Token: 0x06002F65 RID: 12133 RVA: 0x001077CC File Offset: 0x001059CC
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedTransitRouteData()
		{
			Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "AdvancedTransitRouteData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr);
			AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "SourceGUID");
			AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "DestinationGUID");
			AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "FilterMode");
			AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "FilterItemIDs");
			AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, 100668772);
			AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, 100668773);
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00107874 File Offset: 0x00105A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130619, RefRangeEnd = 130620, XrefRangeStart = 130615, XrefRangeEnd = 130619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData(string sourceGUID, string destinationGUID, ManagementItemFilter.EMode filtermode, List<string> filterGUIDs) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filtermode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterGUIDs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x001078F4 File Offset: 0x00105AF4
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x00019163 File Offset: 0x00017363
		public AdvancedTransitRouteData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06002F69 RID: 12137 RVA: 0x00107930 File Offset: 0x00105B30
		// (set) Token: 0x06002F6A RID: 12138 RVA: 0x0001916C File Offset: 0x0001736C
		public unsafe string SourceGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x00107958 File Offset: 0x00105B58
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x0001918B File Offset: 0x0001738B
		public unsafe string DestinationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x00107980 File Offset: 0x00105B80
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x000191AA File Offset: 0x000173AA
		public unsafe ManagementItemFilter.EMode FilterMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode)) = value;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x001079A8 File Offset: 0x00105BA8
		// (set) Token: 0x06002F70 RID: 12144 RVA: 0x000191C5 File Offset: 0x000173C5
		public unsafe List<string> FilterItemIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeFieldInfoPtr_SourceGUID;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeFieldInfoPtr_DestinationGUID;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeFieldInfoPtr_FilterMode;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeFieldInfoPtr_FilterItemIDs;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
