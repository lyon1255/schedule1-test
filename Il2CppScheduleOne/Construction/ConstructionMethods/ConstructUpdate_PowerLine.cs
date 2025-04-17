using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property.Utilities.Power;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200048D RID: 1165
	public class ConstructUpdate_PowerLine : ConstructUpdate_Base
	{
		// Token: 0x060064CD RID: 25805 RVA: 0x001C7A0C File Offset: 0x001C5C0C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_PowerLine()
		{
			Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_PowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr);
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_ghostPowerLine_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "ghostPowerLine_Material");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_cosmeticPowerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "cosmeticPowerNode");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempPowerLineContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "tempPowerLineContainer");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_hoveredPowerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "hoveredPowerNode");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "tempSegments");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_startNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "startNode");
			ConstructUpdate_PowerLine.NativeFieldInfoPtr_powerLineInitialDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, "powerLineInitialDistance");
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676067);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676068);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676069);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676070);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676071);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676072);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676073);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676074);
			ConstructUpdate_PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr, 100676075);
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x001C7B7C File Offset: 0x001C5D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204680, XrefRangeEnd = 204732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerLine.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x001C7BB8 File Offset: 0x001C5DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204732, XrefRangeEnd = 204749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructionStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerLine.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x001C7BF4 File Offset: 0x001C5DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204749, XrefRangeEnd = 204754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerLine.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x001C7C38 File Offset: 0x001C5E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204754, XrefRangeEnd = 204788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerLine.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x001C7C74 File Offset: 0x001C5E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204788, XrefRangeEnd = 204881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerLine.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x001C7CB0 File Offset: 0x001C5EB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204901, RefRangeEnd = 204904, XrefRangeStart = 204881, XrefRangeEnd = 204901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode GetHoveredPowerNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerLine.NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr3) : null;
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x001C7CF0 File Offset: 0x001C5EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204954, RefRangeEnd = 204955, XrefRangeStart = 204904, XrefRangeEnd = 204954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompletePowerLine(PowerNode target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerLine.NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x001C7D34 File Offset: 0x001C5F34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204963, RefRangeEnd = 204965, XrefRangeStart = 204955, XrefRangeEnd = 204963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCreatingPowerLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerLine.NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x001C7D68 File Offset: 0x001C5F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204965, XrefRangeEnd = 204973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_PowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_PowerLine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x0002FA81 File Offset: 0x0002DC81
		public ConstructUpdate_PowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x060064D8 RID: 25816 RVA: 0x001C7DA4 File Offset: 0x001C5FA4
		// (set) Token: 0x060064D9 RID: 25817 RVA: 0x0002FA8A File Offset: 0x0002DC8A
		public unsafe Material ghostPowerLine_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_ghostPowerLine_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_ghostPowerLine_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x060064DA RID: 25818 RVA: 0x001C7DD4 File Offset: 0x001C5FD4
		// (set) Token: 0x060064DB RID: 25819 RVA: 0x0002FAA9 File Offset: 0x0002DCA9
		public unsafe GameObject cosmeticPowerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_cosmeticPowerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_cosmeticPowerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x060064DC RID: 25820 RVA: 0x001C7E04 File Offset: 0x001C6004
		// (set) Token: 0x060064DD RID: 25821 RVA: 0x0002FAC8 File Offset: 0x0002DCC8
		public unsafe Transform tempPowerLineContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempPowerLineContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempPowerLineContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x001C7E34 File Offset: 0x001C6034
		// (set) Token: 0x060064DF RID: 25823 RVA: 0x0002FAE7 File Offset: 0x0002DCE7
		public unsafe PowerNode hoveredPowerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_hoveredPowerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_hoveredPowerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x060064E0 RID: 25824 RVA: 0x001C7E64 File Offset: 0x001C6064
		// (set) Token: 0x060064E1 RID: 25825 RVA: 0x0002FB06 File Offset: 0x0002DD06
		public unsafe List<Transform> tempSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempSegments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_tempSegments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x060064E2 RID: 25826 RVA: 0x001C7E94 File Offset: 0x001C6094
		// (set) Token: 0x060064E3 RID: 25827 RVA: 0x0002FB25 File Offset: 0x0002DD25
		public unsafe PowerNode startNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_startNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_startNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x060064E4 RID: 25828 RVA: 0x001C7EC4 File Offset: 0x001C60C4
		// (set) Token: 0x060064E5 RID: 25829 RVA: 0x0002FB44 File Offset: 0x0002DD44
		public unsafe float powerLineInitialDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_powerLineInitialDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerLine.NativeFieldInfoPtr_powerLineInitialDistance)) = value;
			}
		}

		// Token: 0x040044C6 RID: 17606
		private static readonly IntPtr NativeFieldInfoPtr_ghostPowerLine_Material;

		// Token: 0x040044C7 RID: 17607
		private static readonly IntPtr NativeFieldInfoPtr_cosmeticPowerNode;

		// Token: 0x040044C8 RID: 17608
		private static readonly IntPtr NativeFieldInfoPtr_tempPowerLineContainer;

		// Token: 0x040044C9 RID: 17609
		private static readonly IntPtr NativeFieldInfoPtr_hoveredPowerNode;

		// Token: 0x040044CA RID: 17610
		private static readonly IntPtr NativeFieldInfoPtr_tempSegments;

		// Token: 0x040044CB RID: 17611
		private static readonly IntPtr NativeFieldInfoPtr_startNode;

		// Token: 0x040044CC RID: 17612
		private static readonly IntPtr NativeFieldInfoPtr_powerLineInitialDistance;

		// Token: 0x040044CD RID: 17613
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040044CE RID: 17614
		private static readonly IntPtr NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0;

		// Token: 0x040044CF RID: 17615
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040044D0 RID: 17616
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040044D1 RID: 17617
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x040044D2 RID: 17618
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0;

		// Token: 0x040044D3 RID: 17619
		private static readonly IntPtr NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0;

		// Token: 0x040044D4 RID: 17620
		private static readonly IntPtr NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0;

		// Token: 0x040044D5 RID: 17621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
