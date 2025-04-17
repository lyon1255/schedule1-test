using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200015F RID: 351
	public class SavedCharacterData : Object
	{
		// Token: 0x06001C44 RID: 7236 RVA: 0x000C8358 File Offset: 0x000C6558
		// Note: this type is marked as 'beforefieldinit'.
		static SavedCharacterData()
		{
			Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "SavedCharacterData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr);
			SavedCharacterData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr, "name");
			SavedCharacterData.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr, "path");
			SavedCharacterData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr, 100666247);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x000C83C4 File Offset: 0x000C65C4
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SavedCharacterData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SavedCharacterData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedCharacterData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x000101B3 File Offset: 0x0000E3B3
		public SavedCharacterData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x000C8400 File Offset: 0x000C6600
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x000101BC File Offset: 0x0000E3BC
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedCharacterData.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedCharacterData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x000C8428 File Offset: 0x000C6628
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x000101DB File Offset: 0x0000E3DB
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedCharacterData.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedCharacterData.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
