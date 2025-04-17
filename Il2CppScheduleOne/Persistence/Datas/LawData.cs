using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000270 RID: 624
	public class LawData : SaveData
	{
		// Token: 0x06002F60 RID: 12128 RVA: 0x00107704 File Offset: 0x00105904
		// Note: this type is marked as 'beforefieldinit'.
		static LawData()
		{
			Il2CppClassPointerStore<LawData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LawData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawData>.NativeClassPtr);
			LawData.NativeFieldInfoPtr_InternalLawIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawData>.NativeClassPtr, "InternalLawIntensity");
			LawData.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawData>.NativeClassPtr, 100668771);
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x0010775C File Offset: 0x0010595C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130614, RefRangeEnd = 130615, XrefRangeStart = 130613, XrefRangeEnd = 130614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawData(float internalLawIntensity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref internalLawIntensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawData.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x0001913F File Offset: 0x0001733F
		public LawData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x001077A4 File Offset: 0x001059A4
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x00019148 File Offset: 0x00017348
		public unsafe float InternalLawIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawData.NativeFieldInfoPtr_InternalLawIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawData.NativeFieldInfoPtr_InternalLawIntensity)) = value;
			}
		}

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeFieldInfoPtr_InternalLawIntensity;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
