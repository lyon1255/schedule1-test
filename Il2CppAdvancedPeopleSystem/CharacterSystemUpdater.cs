using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000149 RID: 329
	public static class CharacterSystemUpdater : Object
	{
		// Token: 0x06001B5C RID: 7004 RVA: 0x000C6118 File Offset: 0x000C4318
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSystemUpdater()
		{
			Il2CppClassPointerStore<CharacterSystemUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterSystemUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSystemUpdater>.NativeClassPtr);
			CharacterSystemUpdater.NativeMethodInfoPtr_updateCharacters_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSystemUpdater>.NativeClassPtr, 100666219);
			CharacterSystemUpdater.NativeMethodInfoPtr_UpdateCharactersOnScene_Public_Static_Void_Boolean_CharacterCustomization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSystemUpdater>.NativeClassPtr, 100666220);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x000C6170 File Offset: 0x000C4370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100290, XrefRangeEnd = 100301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void updateCharacters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSystemUpdater.NativeMethodInfoPtr_updateCharacters_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x000C6198 File Offset: 0x000C4398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateCharactersOnScene(bool revertPrefabs = false, CharacterCustomization reverbObject = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref revertPrefabs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reverbObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSystemUpdater.NativeMethodInfoPtr_UpdateCharactersOnScene_Public_Static_Void_Boolean_CharacterCustomization_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0000F755 File Offset: 0x0000D955
		public CharacterSystemUpdater(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_updateCharacters_Private_Static_Void_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCharactersOnScene_Public_Static_Void_Boolean_CharacterCustomization_0;
	}
}
