using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200021E RID: 542
	[Serializable]
	public class TrashContentData : Object
	{
		// Token: 0x06002D1D RID: 11549 RVA: 0x000FFE18 File Offset: 0x000FE018
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContentData()
		{
			Il2CppClassPointerStore<TrashContentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "TrashContentData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr);
			TrashContentData.NativeFieldInfoPtr_TrashIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, "TrashIDs");
			TrashContentData.NativeFieldInfoPtr_TrashQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, "TrashQuantities");
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668469);
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668470);
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668471);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000FFEAC File Offset: 0x000FE0AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126404, RefRangeEnd = 126406, XrefRangeStart = 126395, XrefRangeEnd = 126404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x000FFEE8 File Offset: 0x000FE0E8
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 110661, RefRangeEnd = 110710, XrefRangeStart = 110661, XrefRangeEnd = 110710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData(Il2CppStringArray trashIDs, Il2CppStructArray<int> trashQuantities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashIDs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trashQuantities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000FFF48 File Offset: 0x000FE148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126470, RefRangeEnd = 126471, XrefRangeStart = 126406, XrefRangeEnd = 126470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData(List<TrashItem> trashItems) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItems);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00018398 File Offset: 0x00016598
		public TrashContentData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x000FFF94 File Offset: 0x000FE194
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x000183A1 File Offset: 0x000165A1
		public unsafe Il2CppStringArray TrashIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x000FFFC4 File Offset: 0x000FE1C4
		// (set) Token: 0x06002D25 RID: 11557 RVA: 0x000183C0 File Offset: 0x000165C0
		public unsafe Il2CppStructArray<int> TrashQuantities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashQuantities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeFieldInfoPtr_TrashIDs;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeFieldInfoPtr_TrashQuantities;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0;
	}
}
