using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200014A RID: 330
	public static class CharacterGenerator : Object
	{
		// Token: 0x06001B60 RID: 7008 RVA: 0x000C61DC File Offset: 0x000C43DC
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterGenerator()
		{
			Il2CppClassPointerStore<CharacterGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGenerator>.NativeClassPtr);
			CharacterGenerator.NativeMethodInfoPtr_Generate_Public_Static_Void_CharacterCustomization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGenerator>.NativeClassPtr, 100666221);
			CharacterGenerator.NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_List_1_ExcludeIndexes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGenerator>.NativeClassPtr, 100666222);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x000C6234 File Offset: 0x000C4434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100380, RefRangeEnd = 100381, XrefRangeStart = 100301, XrefRangeEnd = 100380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Generate(CharacterCustomization cc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterGenerator.NativeMethodInfoPtr_Generate_Public_Static_Void_CharacterCustomization_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x000C626C File Offset: 0x000C446C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100417, RefRangeEnd = 100418, XrefRangeStart = 100381, XrefRangeEnd = 100417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_List_1_ExcludeIndexes_0(int hair, int beard, int hat, int accessory, int shirt, int pants, int shoes, List<ExcludeIndexes> excludeIndexes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hair;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beard;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessory;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shirt;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pants;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shoes;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(excludeIndexes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterGenerator.NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_List_1_ExcludeIndexes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0000F75E File Offset: 0x0000D95E
		public CharacterGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Static_Void_CharacterCustomization_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_List_1_ExcludeIndexes_0;
	}
}
