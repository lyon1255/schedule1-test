using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026A RID: 618
	[Serializable]
	public class QualityItemData : ItemData
	{
		// Token: 0x06002F3E RID: 12094 RVA: 0x0010714C File Offset: 0x0010534C
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemData()
		{
			Il2CppClassPointerStore<QualityItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QualityItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr);
			QualityItemData.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr, "Quality");
			QualityItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr, 100668765);
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x001071A4 File Offset: 0x001053A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130436, RefRangeEnd = 130442, XrefRangeStart = 130436, XrefRangeEnd = 130442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemData(string iD, int quantity, string quality) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00018FF0 File Offset: 0x000171F0
		public QualityItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x00107210 File Offset: 0x00105410
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x00018FF9 File Offset: 0x000171F9
		public unsafe string Quality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemData.NativeFieldInfoPtr_Quality);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemData.NativeFieldInfoPtr_Quality), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeFieldInfoPtr_Quality;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0;
	}
}
