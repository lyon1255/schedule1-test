using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025F RID: 607
	public class GameData : SaveData
	{
		// Token: 0x06002EF3 RID: 12019 RVA: 0x001062E4 File Offset: 0x001044E4
		// Note: this type is marked as 'beforefieldinit'.
		static GameData()
		{
			Il2CppClassPointerStore<GameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameData>.NativeClassPtr);
			GameData.NativeFieldInfoPtr_OrganisationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "OrganisationName");
			GameData.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "Seed");
			GameData.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "Settings");
			GameData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameData>.NativeClassPtr, 100668732);
			GameData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameData>.NativeClassPtr, 100668733);
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x00106378 File Offset: 0x00104578
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130436, RefRangeEnd = 130442, XrefRangeStart = 130433, XrefRangeEnd = 130436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameData(string organisationName, int seed, GameSettings settings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(organisationName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x001063E4 File Offset: 0x001045E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130447, RefRangeEnd = 130448, XrefRangeStart = 130442, XrefRangeEnd = 130447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00018D0E File Offset: 0x00016F0E
		public GameData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x00106420 File Offset: 0x00104620
		// (set) Token: 0x06002EF8 RID: 12024 RVA: 0x00018D17 File Offset: 0x00016F17
		public unsafe string OrganisationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_OrganisationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_OrganisationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x00106448 File Offset: 0x00104648
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x00018D36 File Offset: 0x00016F36
		public unsafe int Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Seed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Seed)) = value;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x00106470 File Offset: 0x00104670
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x00018D51 File Offset: 0x00016F51
		public unsafe GameSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeFieldInfoPtr_OrganisationName;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
