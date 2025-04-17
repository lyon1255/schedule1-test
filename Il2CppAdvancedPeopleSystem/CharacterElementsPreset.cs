using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000158 RID: 344
	[Serializable]
	public class CharacterElementsPreset : Il2CppSystem.Object
	{
		// Token: 0x06001C04 RID: 7172 RVA: 0x000C79F0 File Offset: 0x000C5BF0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterElementsPreset()
		{
			Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterElementsPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr);
			CharacterElementsPreset.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, "name");
			CharacterElementsPreset.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, "mesh");
			CharacterElementsPreset.NativeFieldInfoPtr_hideParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, "hideParts");
			CharacterElementsPreset.NativeFieldInfoPtr_yOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, "yOffset");
			CharacterElementsPreset.NativeFieldInfoPtr_mats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, "mats");
			CharacterElementsPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, 100666239);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000C7A98 File Offset: 0x000C5C98
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterElementsPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterElementsPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0000FEE7 File Offset: 0x0000E0E7
		public CharacterElementsPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x000C7AD4 File Offset: 0x000C5CD4
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x000C7AFC File Offset: 0x000C5CFC
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x0000FF0F File Offset: 0x0000E10F
		public unsafe Il2CppReferenceArray<Mesh> mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x000C7B2C File Offset: 0x000C5D2C
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x0000FF2E File Offset: 0x0000E12E
		public unsafe Il2CppStringArray hideParts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_hideParts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_hideParts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x000C7B5C File Offset: 0x000C5D5C
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x0000FF4D File Offset: 0x0000E14D
		public unsafe float yOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_yOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_yOffset)) = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x000C7B84 File Offset: 0x000C5D84
		// (set) Token: 0x06001C10 RID: 7184 RVA: 0x0000FF68 File Offset: 0x0000E168
		public unsafe Il2CppReferenceArray<Material> mats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_mats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_mats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeFieldInfoPtr_hideParts;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeFieldInfoPtr_yOffset;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeFieldInfoPtr_mats;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
