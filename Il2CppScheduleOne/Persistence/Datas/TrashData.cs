using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BA RID: 698
	[Serializable]
	public class TrashData : SaveData
	{
		// Token: 0x060031DD RID: 12765 RVA: 0x0010E830 File Offset: 0x0010CA30
		// Note: this type is marked as 'beforefieldinit'.
		static TrashData()
		{
			Il2CppClassPointerStore<TrashData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashData>.NativeClassPtr);
			TrashData.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashData>.NativeClassPtr, "Items");
			TrashData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashData>.NativeClassPtr, 100668854);
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x0010E888 File Offset: 0x0010CA88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130391, RefRangeEnd = 130397, XrefRangeStart = 130391, XrefRangeEnd = 130397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashData(Il2CppReferenceArray<TrashItemData> trash) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trash);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0001AB61 File Offset: 0x00018D61
		public TrashData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x0010E8D4 File Offset: 0x0010CAD4
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x0001AB6A File Offset: 0x00018D6A
		public unsafe Il2CppReferenceArray<TrashItemData> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItemData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_0;
	}
}
