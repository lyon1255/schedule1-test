using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000543 RID: 1347
	public class ParticleCollisionDetector : MonoBehaviour
	{
		// Token: 0x0600774E RID: 30542 RVA: 0x00205B24 File Offset: 0x00203D24
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleCollisionDetector()
		{
			Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ParticleCollisionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr);
			ParticleCollisionDetector.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, "onCollision");
			ParticleCollisionDetector.NativeFieldInfoPtr_ps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, "ps");
			ParticleCollisionDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678326);
			ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678327);
			ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678328);
			ParticleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678329);
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00205BCC File Offset: 0x00203DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231527, XrefRangeEnd = 231531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00205C00 File Offset: 0x00203E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231531, XrefRangeEnd = 231534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParticleCollision(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x00205C44 File Offset: 0x00203E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231534, XrefRangeEnd = 231544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParticleTrigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00205C78 File Offset: 0x00203E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231544, XrefRangeEnd = 231552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleCollisionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x00038814 File Offset: 0x00036A14
		public ParticleCollisionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x06007754 RID: 30548 RVA: 0x00205CB4 File Offset: 0x00203EB4
		// (set) Token: 0x06007755 RID: 30549 RVA: 0x0003881D File Offset: 0x00036A1D
		public unsafe UnityEvent<GameObject> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x06007756 RID: 30550 RVA: 0x00205CE4 File Offset: 0x00203EE4
		// (set) Token: 0x06007757 RID: 30551 RVA: 0x0003883C File Offset: 0x00036A3C
		public unsafe ParticleSystem ps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_ps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_ps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400516D RID: 20845
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x0400516E RID: 20846
		private static readonly IntPtr NativeFieldInfoPtr_ps;

		// Token: 0x0400516F RID: 20847
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005170 RID: 20848
		private static readonly IntPtr NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0;

		// Token: 0x04005171 RID: 20849
		private static readonly IntPtr NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0;

		// Token: 0x04005172 RID: 20850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
