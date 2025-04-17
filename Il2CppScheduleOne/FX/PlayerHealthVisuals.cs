using System;
using Il2CppBeautify.Universal;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003F8 RID: 1016
	public class PlayerHealthVisuals : MonoBehaviour
	{
		// Token: 0x06005495 RID: 21653 RVA: 0x0018C550 File Offset: 0x0018A750
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerHealthVisuals()
		{
			Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PlayerHealthVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr);
			PlayerHealthVisuals.NativeFieldInfoPtr_GlobalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "GlobalVolume");
			PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "VignetteAlpha_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "VignetteAlpha_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "OuterRingCurve");
			PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "Saturation_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "Saturation_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "ChromAb_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "ChromAb_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "LensDirt_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "LensDirt_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "_beautifySettings");
			PlayerHealthVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673830);
			PlayerHealthVisuals.NativeMethodInfoPtr_Spawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673831);
			PlayerHealthVisuals.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673832);
			PlayerHealthVisuals.NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673833);
			PlayerHealthVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673834);
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x0018C6C0 File Offset: 0x0018A8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180081, XrefRangeEnd = 180150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x0018C6F4 File Offset: 0x0018A8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180150, XrefRangeEnd = 180170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_Spawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x0018C728 File Offset: 0x0018A928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180170, XrefRangeEnd = 180177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x0018C75C File Offset: 0x0018A95C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180182, RefRangeEnd = 180183, XrefRangeStart = 180177, XrefRangeEnd = 180182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects(float newHealth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newHealth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x0018C79C File Offset: 0x0018A99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180183, XrefRangeEnd = 180184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerHealthVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x000288C4 File Offset: 0x00026AC4
		public PlayerHealthVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x0600549C RID: 21660 RVA: 0x0018C7D8 File Offset: 0x0018A9D8
		// (set) Token: 0x0600549D RID: 21661 RVA: 0x000288CD File Offset: 0x00026ACD
		public unsafe Volume GlobalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_GlobalVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_GlobalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x0600549E RID: 21662 RVA: 0x0018C808 File Offset: 0x0018AA08
		// (set) Token: 0x0600549F RID: 21663 RVA: 0x000288EC File Offset: 0x00026AEC
		public unsafe float VignetteAlpha_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth)) = value;
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x060054A0 RID: 21664 RVA: 0x0018C830 File Offset: 0x0018AA30
		// (set) Token: 0x060054A1 RID: 21665 RVA: 0x00028907 File Offset: 0x00026B07
		public unsafe float VignetteAlpha_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth)) = value;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x060054A2 RID: 21666 RVA: 0x0018C858 File Offset: 0x0018AA58
		// (set) Token: 0x060054A3 RID: 21667 RVA: 0x00028922 File Offset: 0x00026B22
		public unsafe AnimationCurve OuterRingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x060054A4 RID: 21668 RVA: 0x0018C888 File Offset: 0x0018AA88
		// (set) Token: 0x060054A5 RID: 21669 RVA: 0x00028941 File Offset: 0x00026B41
		public unsafe float Saturation_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth)) = value;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x0018C8B0 File Offset: 0x0018AAB0
		// (set) Token: 0x060054A7 RID: 21671 RVA: 0x0002895C File Offset: 0x00026B5C
		public unsafe float Saturation_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth)) = value;
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x0018C8D8 File Offset: 0x0018AAD8
		// (set) Token: 0x060054A9 RID: 21673 RVA: 0x00028977 File Offset: 0x00026B77
		public unsafe float ChromAb_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth)) = value;
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x060054AA RID: 21674 RVA: 0x0018C900 File Offset: 0x0018AB00
		// (set) Token: 0x060054AB RID: 21675 RVA: 0x00028992 File Offset: 0x00026B92
		public unsafe float ChromAb_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth)) = value;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x0018C928 File Offset: 0x0018AB28
		// (set) Token: 0x060054AD RID: 21677 RVA: 0x000289AD File Offset: 0x00026BAD
		public unsafe float LensDirt_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth)) = value;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x060054AE RID: 21678 RVA: 0x0018C950 File Offset: 0x0018AB50
		// (set) Token: 0x060054AF RID: 21679 RVA: 0x000289C8 File Offset: 0x00026BC8
		public unsafe float LensDirt_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth)) = value;
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x060054B0 RID: 21680 RVA: 0x0018C978 File Offset: 0x0018AB78
		// (set) Token: 0x060054B1 RID: 21681 RVA: 0x000289E3 File Offset: 0x00026BE3
		public unsafe Beautify _beautifySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beautify>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003945 RID: 14661
		private static readonly IntPtr NativeFieldInfoPtr_GlobalVolume;

		// Token: 0x04003946 RID: 14662
		private static readonly IntPtr NativeFieldInfoPtr_VignetteAlpha_MaxHealth;

		// Token: 0x04003947 RID: 14663
		private static readonly IntPtr NativeFieldInfoPtr_VignetteAlpha_MinHealth;

		// Token: 0x04003948 RID: 14664
		private static readonly IntPtr NativeFieldInfoPtr_OuterRingCurve;

		// Token: 0x04003949 RID: 14665
		private static readonly IntPtr NativeFieldInfoPtr_Saturation_MaxHealth;

		// Token: 0x0400394A RID: 14666
		private static readonly IntPtr NativeFieldInfoPtr_Saturation_MinHealth;

		// Token: 0x0400394B RID: 14667
		private static readonly IntPtr NativeFieldInfoPtr_ChromAb_MaxHealth;

		// Token: 0x0400394C RID: 14668
		private static readonly IntPtr NativeFieldInfoPtr_ChromAb_MinHealth;

		// Token: 0x0400394D RID: 14669
		private static readonly IntPtr NativeFieldInfoPtr_LensDirt_MaxHealth;

		// Token: 0x0400394E RID: 14670
		private static readonly IntPtr NativeFieldInfoPtr_LensDirt_MinHealth;

		// Token: 0x0400394F RID: 14671
		private static readonly IntPtr NativeFieldInfoPtr__beautifySettings;

		// Token: 0x04003950 RID: 14672
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003951 RID: 14673
		private static readonly IntPtr NativeMethodInfoPtr_Spawned_Private_Void_0;

		// Token: 0x04003952 RID: 14674
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003953 RID: 14675
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0;

		// Token: 0x04003954 RID: 14676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
