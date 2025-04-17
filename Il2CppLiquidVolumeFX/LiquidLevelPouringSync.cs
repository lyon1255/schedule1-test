using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D3 RID: 211
	public class LiquidLevelPouringSync : MonoBehaviour
	{
		// Token: 0x06000F9B RID: 3995 RVA: 0x000A1578 File Offset: 0x0009F778
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidLevelPouringSync()
		{
			Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "LiquidLevelPouringSync");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr);
			LiquidLevelPouringSync.NativeFieldInfoPtr_fillSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, "fillSpeed");
			LiquidLevelPouringSync.NativeFieldInfoPtr_sinkFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, "sinkFactor");
			LiquidLevelPouringSync.NativeFieldInfoPtr_lv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, "lv");
			LiquidLevelPouringSync.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, "rb");
			LiquidLevelPouringSync.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, 100665096);
			LiquidLevelPouringSync.NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, 100665097);
			LiquidLevelPouringSync.NativeMethodInfoPtr_UpdateColliderPos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, 100665098);
			LiquidLevelPouringSync.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr, 100665099);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000A1648 File Offset: 0x0009F848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86353, XrefRangeEnd = 86365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelPouringSync.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000A167C File Offset: 0x0009F87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86365, XrefRangeEnd = 86368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParticleCollision(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelPouringSync.NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000A16C0 File Offset: 0x0009F8C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86383, RefRangeEnd = 86385, XrefRangeStart = 86368, XrefRangeEnd = 86383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColliderPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelPouringSync.NativeMethodInfoPtr_UpdateColliderPos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000A16F4 File Offset: 0x0009F8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86385, XrefRangeEnd = 86386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidLevelPouringSync() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidLevelPouringSync>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelPouringSync.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00009C9E File Offset: 0x00007E9E
		public LiquidLevelPouringSync(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x000A1730 File Offset: 0x0009F930
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x00009CA7 File Offset: 0x00007EA7
		public unsafe float fillSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_fillSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_fillSpeed)) = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x000A1758 File Offset: 0x0009F958
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public unsafe float sinkFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_sinkFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_sinkFactor)) = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x000A1780 File Offset: 0x0009F980
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x00009CDD File Offset: 0x00007EDD
		public unsafe LiquidVolume lv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_lv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_lv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x000A17B0 File Offset: 0x0009F9B0
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x00009CFC File Offset: 0x00007EFC
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelPouringSync.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr_fillSpeed;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_sinkFactor;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr_lv;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColliderPos_Private_Void_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
