using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D3 RID: 1235
	public class ImpactSoundEntity : MonoBehaviour
	{
		// Token: 0x06006C10 RID: 27664 RVA: 0x001E044C File Offset: 0x001DE64C
		// Note: this type is marked as 'beforefieldinit'.
		static ImpactSoundEntity()
		{
			Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "ImpactSoundEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr);
			ImpactSoundEntity.NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "MIN_IMPACT_MOMENTUM");
			ImpactSoundEntity.NativeFieldInfoPtr_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "COOLDOWN");
			ImpactSoundEntity.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "Material");
			ImpactSoundEntity.NativeFieldInfoPtr_lastImpactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "lastImpactTime");
			ImpactSoundEntity.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "rb");
			ImpactSoundEntity.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100676959);
			ImpactSoundEntity.NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100676960);
			ImpactSoundEntity.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100676961);
			ImpactSoundEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100676962);
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x001E0530 File Offset: 0x001DE730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216501, XrefRangeEnd = 216528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x001E0564 File Offset: 0x001DE764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216528, XrefRangeEnd = 216541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnImpacted(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x001E05A8 File Offset: 0x001DE7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216541, XrefRangeEnd = 216568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x001E05EC File Offset: 0x001DE7EC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpactSoundEntity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x0003328A File Offset: 0x0003148A
		public ImpactSoundEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06006C16 RID: 27670 RVA: 0x001E0628 File Offset: 0x001DE828
		// (set) Token: 0x06006C17 RID: 27671 RVA: 0x00033293 File Offset: 0x00031493
		public unsafe static float MIN_IMPACT_MOMENTUM
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ImpactSoundEntity.NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImpactSoundEntity.NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM, (void*)(&value));
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06006C18 RID: 27672 RVA: 0x001E0644 File Offset: 0x001DE844
		// (set) Token: 0x06006C19 RID: 27673 RVA: 0x000332A1 File Offset: 0x000314A1
		public unsafe static float COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ImpactSoundEntity.NativeFieldInfoPtr_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImpactSoundEntity.NativeFieldInfoPtr_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06006C1A RID: 27674 RVA: 0x001E0660 File Offset: 0x001DE860
		// (set) Token: 0x06006C1B RID: 27675 RVA: 0x000332AF File Offset: 0x000314AF
		public unsafe ImpactSoundEntity.EMaterial Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_Material);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_Material)) = value;
			}
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06006C1C RID: 27676 RVA: 0x001E0688 File Offset: 0x001DE888
		// (set) Token: 0x06006C1D RID: 27677 RVA: 0x000332CA File Offset: 0x000314CA
		public unsafe float lastImpactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_lastImpactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_lastImpactTime)) = value;
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06006C1E RID: 27678 RVA: 0x001E06B0 File Offset: 0x001DE8B0
		// (set) Token: 0x06006C1F RID: 27679 RVA: 0x000332E5 File Offset: 0x000314E5
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049E6 RID: 18918
		private static readonly IntPtr NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM;

		// Token: 0x040049E7 RID: 18919
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN;

		// Token: 0x040049E8 RID: 18920
		private static readonly IntPtr NativeFieldInfoPtr_Material;

		// Token: 0x040049E9 RID: 18921
		private static readonly IntPtr NativeFieldInfoPtr_lastImpactTime;

		// Token: 0x040049EA RID: 18922
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x040049EB RID: 18923
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040049EC RID: 18924
		private static readonly IntPtr NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0;

		// Token: 0x040049ED RID: 18925
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x040049EE RID: 18926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A5E RID: 2654
		[OriginalName("Assembly-CSharp.dll", "", "EMaterial")]
		public enum EMaterial
		{
			// Token: 0x04008CCC RID: 36044
			Wood,
			// Token: 0x04008CCD RID: 36045
			HollowMetal,
			// Token: 0x04008CCE RID: 36046
			Cardboard,
			// Token: 0x04008CCF RID: 36047
			Glass,
			// Token: 0x04008CD0 RID: 36048
			Plastic,
			// Token: 0x04008CD1 RID: 36049
			Basketball,
			// Token: 0x04008CD2 RID: 36050
			SmallHollowMetal,
			// Token: 0x04008CD3 RID: 36051
			PlasticBag,
			// Token: 0x04008CD4 RID: 36052
			Punch,
			// Token: 0x04008CD5 RID: 36053
			BaseballBat
		}
	}
}
