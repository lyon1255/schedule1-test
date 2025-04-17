using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000047 RID: 71
	public class ExampleWheelController : MonoBehaviour
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x0008220C File Offset: 0x0008040C
		// Note: this type is marked as 'beforefieldinit'.
		static ExampleWheelController()
		{
			Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ExampleWheelController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr);
			ExampleWheelController.NativeFieldInfoPtr_acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, "acceleration");
			ExampleWheelController.NativeFieldInfoPtr_motionVectorRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, "motionVectorRenderer");
			ExampleWheelController.NativeFieldInfoPtr_m_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, "m_Rigidbody");
			ExampleWheelController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, 100663859);
			ExampleWheelController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, 100663860);
			ExampleWheelController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, 100663861);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000822B4 File Offset: 0x000804B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75733, XrefRangeEnd = 75739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExampleWheelController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000822E8 File Offset: 0x000804E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75739, XrefRangeEnd = 75754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExampleWheelController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0008231C File Offset: 0x0008051C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExampleWheelController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExampleWheelController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000057F7 File Offset: 0x000039F7
		public ExampleWheelController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00082358 File Offset: 0x00080558
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x00005800 File Offset: 0x00003A00
		public unsafe float acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_acceleration)) = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00082380 File Offset: 0x00080580
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x0000581B File Offset: 0x00003A1B
		public unsafe Renderer motionVectorRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_motionVectorRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_motionVectorRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x000823B0 File Offset: 0x000805B0
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x0000583A File Offset: 0x00003A3A
		public unsafe Rigidbody m_Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_m_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExampleWheelController.NativeFieldInfoPtr_m_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr_acceleration;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_motionVectorRenderer;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr_m_Rigidbody;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C1 RID: 1985
		public static class Uniforms : Il2CppSystem.Object
		{
			// Token: 0x0600BAB2 RID: 47794 RVA: 0x0005B5CC File Offset: 0x000597CC
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<ExampleWheelController.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExampleWheelController>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExampleWheelController.Uniforms>.NativeClassPtr);
				ExampleWheelController.Uniforms.NativeFieldInfoPtr__MotionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExampleWheelController.Uniforms>.NativeClassPtr, "_MotionAmount");
			}

			// Token: 0x0600BAB3 RID: 47795 RVA: 0x0005B600 File Offset: 0x00059800
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039A9 RID: 14761
			// (get) Token: 0x0600BAB4 RID: 47796 RVA: 0x002E4344 File Offset: 0x002E2544
			// (set) Token: 0x0600BAB5 RID: 47797 RVA: 0x0005B609 File Offset: 0x00059809
			public unsafe static int _MotionAmount
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ExampleWheelController.Uniforms.NativeFieldInfoPtr__MotionAmount, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExampleWheelController.Uniforms.NativeFieldInfoPtr__MotionAmount, (void*)(&value));
				}
			}

			// Token: 0x04007DED RID: 32237
			private static readonly IntPtr NativeFieldInfoPtr__MotionAmount;
		}
	}
}
