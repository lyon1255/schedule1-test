using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Property.Utilities.Power;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200048E RID: 1166
	public class ConstructUpdate_PowerTower : ConstructUpdate_OutdoorGrid
	{
		// Token: 0x060064E6 RID: 25830 RVA: 0x001C7EEC File Offset: 0x001C60EC
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_PowerTower()
		{
			Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_PowerTower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr);
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_specialMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "specialMat");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLine_GhostMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "powerLine_GhostMat");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_cosmeticPowerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "cosmeticPowerNode");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "LengthFactor");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempPowerLineContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "tempPowerLineContainer");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "tempSegments");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_hoveredPowerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "hoveredPowerNode");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_startNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "startNode");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLineInitialDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "powerLineInitialDistance");
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676076);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676077);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676078);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676079);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676080);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerTower_Private_PowerTower_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676081);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676082);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676083);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676084);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676085);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676086);
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x001C80AC File Offset: 0x001C62AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204973, XrefRangeEnd = 205038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x001C80E8 File Offset: 0x001C62E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205038, XrefRangeEnd = 205049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructionStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x001C8124 File Offset: 0x001C6324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205049, XrefRangeEnd = 205103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x001C8160 File Offset: 0x001C6360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205103, XrefRangeEnd = 205186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x001C819C File Offset: 0x001C639C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205186, XrefRangeEnd = 205191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x001C81E0 File Offset: 0x001C63E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205191, XrefRangeEnd = 205224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerTower GetHoveredPowerTower()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerTower_Private_PowerTower_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerTower>(intPtr3) : null;
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x001C8220 File Offset: 0x001C6420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205244, RefRangeEnd = 205246, XrefRangeStart = 205224, XrefRangeEnd = 205244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode GetHoveredPowerNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr3) : null;
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x001C8260 File Offset: 0x001C6460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205246, XrefRangeEnd = 205275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Constructable_GridBased PlaceNewConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr3) : null;
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x001C82AC File Offset: 0x001C64AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205298, RefRangeEnd = 205299, XrefRangeStart = 205275, XrefRangeEnd = 205298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompletePowerLine(PowerNode target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x001C82F0 File Offset: 0x001C64F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205312, RefRangeEnd = 205315, XrefRangeStart = 205299, XrefRangeEnd = 205312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCreatingPowerLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x001C8324 File Offset: 0x001C6524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205315, XrefRangeEnd = 205323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_PowerTower() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x0002FB5F File Offset: 0x0002DD5F
		public ConstructUpdate_PowerTower(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x060064F3 RID: 25843 RVA: 0x001C8360 File Offset: 0x001C6560
		// (set) Token: 0x060064F4 RID: 25844 RVA: 0x0002FB68 File Offset: 0x0002DD68
		public unsafe Material specialMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_specialMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_specialMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x060064F5 RID: 25845 RVA: 0x001C8390 File Offset: 0x001C6590
		// (set) Token: 0x060064F6 RID: 25846 RVA: 0x0002FB87 File Offset: 0x0002DD87
		public unsafe Material powerLine_GhostMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLine_GhostMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLine_GhostMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x060064F7 RID: 25847 RVA: 0x001C83C0 File Offset: 0x001C65C0
		// (set) Token: 0x060064F8 RID: 25848 RVA: 0x0002FBA6 File Offset: 0x0002DDA6
		public unsafe GameObject cosmeticPowerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_cosmeticPowerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_cosmeticPowerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x060064F9 RID: 25849 RVA: 0x001C83F0 File Offset: 0x001C65F0
		// (set) Token: 0x060064FA RID: 25850 RVA: 0x0002FBC5 File Offset: 0x0002DDC5
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x060064FB RID: 25851 RVA: 0x001C8418 File Offset: 0x001C6618
		// (set) Token: 0x060064FC RID: 25852 RVA: 0x0002FBE0 File Offset: 0x0002DDE0
		public unsafe Transform tempPowerLineContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempPowerLineContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempPowerLineContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x060064FD RID: 25853 RVA: 0x001C8448 File Offset: 0x001C6648
		// (set) Token: 0x060064FE RID: 25854 RVA: 0x0002FBFF File Offset: 0x0002DDFF
		public unsafe List<Transform> tempSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempSegments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempSegments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x060064FF RID: 25855 RVA: 0x001C8478 File Offset: 0x001C6678
		// (set) Token: 0x06006500 RID: 25856 RVA: 0x0002FC1E File Offset: 0x0002DE1E
		public unsafe PowerNode hoveredPowerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_hoveredPowerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_hoveredPowerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06006501 RID: 25857 RVA: 0x001C84A8 File Offset: 0x001C66A8
		// (set) Token: 0x06006502 RID: 25858 RVA: 0x0002FC3D File Offset: 0x0002DE3D
		public unsafe PowerNode startNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_startNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_startNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06006503 RID: 25859 RVA: 0x001C84D8 File Offset: 0x001C66D8
		// (set) Token: 0x06006504 RID: 25860 RVA: 0x0002FC5C File Offset: 0x0002DE5C
		public unsafe float powerLineInitialDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLineInitialDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLineInitialDistance)) = value;
			}
		}

		// Token: 0x040044D6 RID: 17622
		private static readonly IntPtr NativeFieldInfoPtr_specialMat;

		// Token: 0x040044D7 RID: 17623
		private static readonly IntPtr NativeFieldInfoPtr_powerLine_GhostMat;

		// Token: 0x040044D8 RID: 17624
		private static readonly IntPtr NativeFieldInfoPtr_cosmeticPowerNode;

		// Token: 0x040044D9 RID: 17625
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x040044DA RID: 17626
		private static readonly IntPtr NativeFieldInfoPtr_tempPowerLineContainer;

		// Token: 0x040044DB RID: 17627
		private static readonly IntPtr NativeFieldInfoPtr_tempSegments;

		// Token: 0x040044DC RID: 17628
		private static readonly IntPtr NativeFieldInfoPtr_hoveredPowerNode;

		// Token: 0x040044DD RID: 17629
		private static readonly IntPtr NativeFieldInfoPtr_startNode;

		// Token: 0x040044DE RID: 17630
		private static readonly IntPtr NativeFieldInfoPtr_powerLineInitialDistance;

		// Token: 0x040044DF RID: 17631
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040044E0 RID: 17632
		private static readonly IntPtr NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0;

		// Token: 0x040044E1 RID: 17633
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040044E2 RID: 17634
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x040044E3 RID: 17635
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040044E4 RID: 17636
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredPowerTower_Private_PowerTower_0;

		// Token: 0x040044E5 RID: 17637
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0;

		// Token: 0x040044E6 RID: 17638
		private static readonly IntPtr NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_Constructable_GridBased_0;

		// Token: 0x040044E7 RID: 17639
		private static readonly IntPtr NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0;

		// Token: 0x040044E8 RID: 17640
		private static readonly IntPtr NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0;

		// Token: 0x040044E9 RID: 17641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
