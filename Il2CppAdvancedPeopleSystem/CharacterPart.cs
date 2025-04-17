using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000143 RID: 323
	[Serializable]
	public class CharacterPart : Il2CppSystem.Object
	{
		// Token: 0x06001B08 RID: 6920 RVA: 0x000C5430 File Offset: 0x000C3630
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterPart()
		{
			Il2CppClassPointerStore<CharacterPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterPart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterPart>.NativeClassPtr);
			CharacterPart.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPart>.NativeClassPtr, "name");
			CharacterPart.NativeFieldInfoPtr_skinnedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPart>.NativeClassPtr, "skinnedMesh");
			CharacterPart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPart>.NativeClassPtr, 100666196);
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000C549C File Offset: 0x000C369C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99586, RefRangeEnd = 99587, XrefRangeStart = 99578, XrefRangeEnd = 99586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterPart() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterPart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterPart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0000F400 File Offset: 0x0000D600
		public CharacterPart(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x000C54D8 File Offset: 0x000C36D8
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x0000F409 File Offset: 0x0000D609
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPart.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPart.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x000C5500 File Offset: 0x000C3700
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x0000F428 File Offset: 0x0000D628
		public unsafe List<SkinnedMeshRenderer> skinnedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPart.NativeFieldInfoPtr_skinnedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPart.NativeFieldInfoPtr_skinnedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMesh;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
