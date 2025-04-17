using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppStylizedGrassDemo
{
	// Token: 0x020000C5 RID: 197
	public class PlayerController : MonoBehaviour
	{
		// Token: 0x06000EAE RID: 3758 RVA: 0x0009F314 File Offset: 0x0009D514
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerController()
		{
			Il2CppClassPointerStore<PlayerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "StylizedGrassDemo", "PlayerController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController>.NativeClassPtr);
			PlayerController.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "cam");
			PlayerController.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "speed");
			PlayerController.NativeFieldInfoPtr_jumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "jumpForce");
			PlayerController.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "rb");
			PlayerController.NativeFieldInfoPtr_isGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "isGrounded");
			PlayerController.NativeFieldInfoPtr_landBendEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "landBendEffect");
			PlayerController.NativeFieldInfoPtr_raycastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "raycastHit");
			PlayerController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665051);
			PlayerController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665052);
			PlayerController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665053);
			PlayerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665054);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0009F420 File Offset: 0x0009D620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85865, XrefRangeEnd = 85875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0009F454 File Offset: 0x0009D654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85875, XrefRangeEnd = 85889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0009F488 File Offset: 0x0009D688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85889, XrefRangeEnd = 85915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0009F4BC File Offset: 0x0009D6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85915, XrefRangeEnd = 85916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00009306 File Offset: 0x00007506
		public PlayerController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x0009F4F8 File Offset: 0x0009D6F8
		// (set) Token: 0x06000EB5 RID: 3765 RVA: 0x0000930F File Offset: 0x0000750F
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0009F528 File Offset: 0x0009D728
		// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x0000932E File Offset: 0x0000752E
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0009F550 File Offset: 0x0009D750
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x00009349 File Offset: 0x00007549
		public unsafe float jumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_jumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_jumpForce)) = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0009F578 File Offset: 0x0009D778
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x00009364 File Offset: 0x00007564
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0009F5A8 File Offset: 0x0009D7A8
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x00009383 File Offset: 0x00007583
		public unsafe bool isGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_isGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_isGrounded)) = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0009F5D0 File Offset: 0x0009D7D0
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x0000939E File Offset: 0x0000759E
		public unsafe ParticleSystem landBendEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_landBendEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_landBendEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0009F600 File Offset: 0x0009D800
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x000093BD File Offset: 0x000075BD
		public unsafe RaycastHit raycastHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_raycastHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_raycastHit)) = value;
			}
		}

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeFieldInfoPtr_jumpForce;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeFieldInfoPtr_isGrounded;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr_landBendEffect;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_raycastHit;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
