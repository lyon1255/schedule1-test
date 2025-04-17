using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000159 RID: 345
	[Serializable]
	public class CharacterAnimationPreset : Il2CppSystem.Object
	{
		// Token: 0x06001C11 RID: 7185 RVA: 0x000C7BB4 File Offset: 0x000C5DB4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterAnimationPreset()
		{
			Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterAnimationPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr);
			CharacterAnimationPreset.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "name");
			CharacterAnimationPreset.NativeFieldInfoPtr_blendshapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "blendshapes");
			CharacterAnimationPreset.NativeFieldInfoPtr_UseGlobalBlendCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "UseGlobalBlendCurve");
			CharacterAnimationPreset.NativeFieldInfoPtr_GlobalBlendAnimationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "GlobalBlendAnimationCurve");
			CharacterAnimationPreset.NativeFieldInfoPtr_AnimationPlayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "AnimationPlayDuration");
			CharacterAnimationPreset.NativeFieldInfoPtr_weightPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "weightPower");
			CharacterAnimationPreset.NativeFieldInfoPtr_applyToAllCharacterMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, "applyToAllCharacterMeshes");
			CharacterAnimationPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr, 100666240);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x000C7C84 File Offset: 0x000C5E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100584, XrefRangeEnd = 100603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterAnimationPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAnimationPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0000FF87 File Offset: 0x0000E187
		public CharacterAnimationPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x000C7CC0 File Offset: 0x000C5EC0
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x0000FF90 File Offset: 0x0000E190
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x000C7CE8 File Offset: 0x000C5EE8
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x0000FFAF File Offset: 0x0000E1AF
		public unsafe List<BlendshapeEmotionValue> blendshapes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_blendshapes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BlendshapeEmotionValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_blendshapes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x000C7D18 File Offset: 0x000C5F18
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x0000FFCE File Offset: 0x0000E1CE
		public unsafe bool UseGlobalBlendCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_UseGlobalBlendCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_UseGlobalBlendCurve)) = value;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x000C7D40 File Offset: 0x000C5F40
		// (set) Token: 0x06001C1B RID: 7195 RVA: 0x0000FFE9 File Offset: 0x0000E1E9
		public unsafe AnimationCurve GlobalBlendAnimationCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_GlobalBlendAnimationCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_GlobalBlendAnimationCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x000C7D70 File Offset: 0x000C5F70
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x00010008 File Offset: 0x0000E208
		public unsafe float AnimationPlayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_AnimationPlayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_AnimationPlayDuration)) = value;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x000C7D98 File Offset: 0x000C5F98
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x00010023 File Offset: 0x0000E223
		public unsafe float weightPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_weightPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_weightPower)) = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000C7DC0 File Offset: 0x000C5FC0
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x0001003E File Offset: 0x0000E23E
		public unsafe bool applyToAllCharacterMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_applyToAllCharacterMeshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimationPreset.NativeFieldInfoPtr_applyToAllCharacterMeshes)) = value;
			}
		}

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeFieldInfoPtr_blendshapes;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeFieldInfoPtr_UseGlobalBlendCurve;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeFieldInfoPtr_GlobalBlendAnimationCurve;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeFieldInfoPtr_AnimationPlayDuration;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeFieldInfoPtr_weightPower;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeFieldInfoPtr_applyToAllCharacterMeshes;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
