using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000157 RID: 343
	[Serializable]
	public class CharacterSettingsSelector : Object
	{
		// Token: 0x06001BFD RID: 7165 RVA: 0x000C78F0 File Offset: 0x000C5AF0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSettingsSelector()
		{
			Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterSettingsSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr);
			CharacterSettingsSelector.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr, "name");
			CharacterSettingsSelector.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr, "settings");
			CharacterSettingsSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr, 100666238);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x000C795C File Offset: 0x000C5B5C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSettingsSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSettingsSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSettingsSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		public CharacterSettingsSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x000C7998 File Offset: 0x000C5B98
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x0000FEA9 File Offset: 0x0000E0A9
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettingsSelector.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettingsSelector.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000C79C0 File Offset: 0x000C5BC0
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		public unsafe CharacterSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettingsSelector.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSettingsSelector.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
