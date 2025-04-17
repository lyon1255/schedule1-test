using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000146 RID: 326
	public class CurrentBlendshapeAnimation : Object
	{
		// Token: 0x06001B1F RID: 6943 RVA: 0x000C576C File Offset: 0x000C396C
		// Note: this type is marked as 'beforefieldinit'.
		static CurrentBlendshapeAnimation()
		{
			Il2CppClassPointerStore<CurrentBlendshapeAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CurrentBlendshapeAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurrentBlendshapeAnimation>.NativeClassPtr);
			CurrentBlendshapeAnimation.NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentBlendshapeAnimation>.NativeClassPtr, "preset");
			CurrentBlendshapeAnimation.NativeFieldInfoPtr_blendShapesTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentBlendshapeAnimation>.NativeClassPtr, "blendShapesTemp");
			CurrentBlendshapeAnimation.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentBlendshapeAnimation>.NativeClassPtr, "timer");
			CurrentBlendshapeAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentBlendshapeAnimation>.NativeClassPtr, 100666199);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x000C57EC File Offset: 0x000C39EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99608, XrefRangeEnd = 99616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurrentBlendshapeAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurrentBlendshapeAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentBlendshapeAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
		public CurrentBlendshapeAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x000C5828 File Offset: 0x000C3A28
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x0000F4F1 File Offset: 0x0000D6F1
		public unsafe CharacterAnimationPreset preset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentBlendshapeAnimation.NativeFieldInfoPtr_preset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterAnimationPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentBlendshapeAnimation.NativeFieldInfoPtr_preset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x000C5858 File Offset: 0x000C3A58
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x0000F510 File Offset: 0x0000D710
		public unsafe List<BlendshapeEmotionValue> blendShapesTemp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentBlendshapeAnimation.NativeFieldInfoPtr_blendShapesTemp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BlendshapeEmotionValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentBlendshapeAnimation.NativeFieldInfoPtr_blendShapesTemp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x000C5888 File Offset: 0x000C3A88
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0000F52F File Offset: 0x0000D72F
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentBlendshapeAnimation.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentBlendshapeAnimation.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeFieldInfoPtr_preset;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeFieldInfoPtr_blendShapesTemp;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
