using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000259 RID: 601
	[Serializable]
	public class AvatarAppearanceData : SaveData
	{
		// Token: 0x06002EAD RID: 11949 RVA: 0x001057C0 File Offset: 0x001039C0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarAppearanceData()
		{
			Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "AvatarAppearanceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr);
			AvatarAppearanceData.NativeFieldInfoPtr_AvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr, "AvatarSettings");
			AvatarAppearanceData.NativeMethodInfoPtr__ctor_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr, 100668724);
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00105818 File Offset: 0x00103A18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130391, RefRangeEnd = 130397, XrefRangeStart = 130389, XrefRangeEnd = 130391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarAppearanceData(AvatarSettings avatarSettings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatarSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAppearanceData.NativeMethodInfoPtr__ctor_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00018A19 File Offset: 0x00016C19
		public AvatarAppearanceData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x00105864 File Offset: 0x00103A64
		// (set) Token: 0x06002EB1 RID: 11953 RVA: 0x00018A22 File Offset: 0x00016C22
		public unsafe AvatarSettings AvatarSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAppearanceData.NativeFieldInfoPtr_AvatarSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAppearanceData.NativeFieldInfoPtr_AvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeFieldInfoPtr_AvatarSettings;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AvatarSettings_0;
	}
}
