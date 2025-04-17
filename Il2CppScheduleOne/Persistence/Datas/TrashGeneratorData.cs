﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BB RID: 699
	public class TrashGeneratorData : SaveData
	{
		// Token: 0x060031E2 RID: 12770 RVA: 0x0010E904 File Offset: 0x0010CB04
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGeneratorData()
		{
			Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashGeneratorData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr);
			TrashGeneratorData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, "GUID");
			TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, "GeneratedItems");
			TrashGeneratorData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, 100668855);
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x0010E970 File Offset: 0x0010CB70
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130629, RefRangeEnd = 130638, XrefRangeStart = 130629, XrefRangeEnd = 130638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGeneratorData(string guid, Il2CppStringArray generatedItems) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generatedItems);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGeneratorData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x0001AB89 File Offset: 0x00018D89
		public TrashGeneratorData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x060031E5 RID: 12773 RVA: 0x0010E9D0 File Offset: 0x0010CBD0
		// (set) Token: 0x060031E6 RID: 12774 RVA: 0x0001AB92 File Offset: 0x00018D92
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x0010E9F8 File Offset: 0x0010CBF8
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x0001ABB1 File Offset: 0x00018DB1
		public unsafe Il2CppStringArray GeneratedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeFieldInfoPtr_GeneratedItems;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0;
	}
}
