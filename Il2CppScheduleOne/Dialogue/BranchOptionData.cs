using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000444 RID: 1092
	[Serializable]
	public class BranchOptionData : Object
	{
		// Token: 0x06005F5E RID: 24414 RVA: 0x001B61A4 File Offset: 0x001B43A4
		// Note: this type is marked as 'beforefieldinit'.
		static BranchOptionData()
		{
			Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "BranchOptionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr);
			BranchOptionData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr, "Guid");
			BranchOptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr, 100675469);
		}

		// Token: 0x06005F5F RID: 24415 RVA: 0x001B61FC File Offset: 0x001B43FC
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchOptionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchOptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x0002CF69 File Offset: 0x0002B169
		public BranchOptionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06005F61 RID: 24417 RVA: 0x001B6238 File Offset: 0x001B4438
		// (set) Token: 0x06005F62 RID: 24418 RVA: 0x0002CF72 File Offset: 0x0002B172
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchOptionData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchOptionData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004137 RID: 16695
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04004138 RID: 16696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
