using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000555 RID: 1365
	public class FunctionalSeed : MonoBehaviour
	{
		// Token: 0x0600782A RID: 30762 RVA: 0x002080C0 File Offset: 0x002062C0
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalSeed()
		{
			Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "FunctionalSeed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr);
			FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "onSeedExitVial");
			FunctionalSeed.NativeFieldInfoPtr_Vial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "Vial");
			FunctionalSeed.NativeFieldInfoPtr_SeedBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedBlocker");
			FunctionalSeed.NativeFieldInfoPtr_Cap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "Cap");
			FunctionalSeed.NativeFieldInfoPtr_SeedCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedCollider");
			FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedRigidbody");
			FunctionalSeed.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "TrashPrefab");
			FunctionalSeed.NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, 100678398);
			FunctionalSeed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, 100678399);
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x002081A4 File Offset: 0x002063A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232215, XrefRangeEnd = 232219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalSeed.NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x002081E8 File Offset: 0x002063E8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalSeed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalSeed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x00038F54 File Offset: 0x00037154
		public FunctionalSeed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x0600782E RID: 30766 RVA: 0x00208224 File Offset: 0x00206424
		// (set) Token: 0x0600782F RID: 30767 RVA: 0x00038F5D File Offset: 0x0003715D
		public unsafe Action onSeedExitVial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x06007830 RID: 30768 RVA: 0x00208254 File Offset: 0x00206454
		// (set) Token: 0x06007831 RID: 30769 RVA: 0x00038F7C File Offset: 0x0003717C
		public unsafe Draggable Vial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Vial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Vial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x06007832 RID: 30770 RVA: 0x00208284 File Offset: 0x00206484
		// (set) Token: 0x06007833 RID: 30771 RVA: 0x00038F9B File Offset: 0x0003719B
		public unsafe Collider SeedBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x06007834 RID: 30772 RVA: 0x002082B4 File Offset: 0x002064B4
		// (set) Token: 0x06007835 RID: 30773 RVA: 0x00038FBA File Offset: 0x000371BA
		public unsafe VialCap Cap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Cap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VialCap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Cap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x06007836 RID: 30774 RVA: 0x002082E4 File Offset: 0x002064E4
		// (set) Token: 0x06007837 RID: 30775 RVA: 0x00038FD9 File Offset: 0x000371D9
		public unsafe Collider SeedCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x06007838 RID: 30776 RVA: 0x00208314 File Offset: 0x00206514
		// (set) Token: 0x06007839 RID: 30777 RVA: 0x00038FF8 File Offset: 0x000371F8
		public unsafe Rigidbody SeedRigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x0600783A RID: 30778 RVA: 0x00208344 File Offset: 0x00206544
		// (set) Token: 0x0600783B RID: 30779 RVA: 0x00039017 File Offset: 0x00037217
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_TrashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051E9 RID: 20969
		private static readonly IntPtr NativeFieldInfoPtr_onSeedExitVial;

		// Token: 0x040051EA RID: 20970
		private static readonly IntPtr NativeFieldInfoPtr_Vial;

		// Token: 0x040051EB RID: 20971
		private static readonly IntPtr NativeFieldInfoPtr_SeedBlocker;

		// Token: 0x040051EC RID: 20972
		private static readonly IntPtr NativeFieldInfoPtr_Cap;

		// Token: 0x040051ED RID: 20973
		private static readonly IntPtr NativeFieldInfoPtr_SeedCollider;

		// Token: 0x040051EE RID: 20974
		private static readonly IntPtr NativeFieldInfoPtr_SeedRigidbody;

		// Token: 0x040051EF RID: 20975
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x040051F0 RID: 20976
		private static readonly IntPtr NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0;

		// Token: 0x040051F1 RID: 20977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
