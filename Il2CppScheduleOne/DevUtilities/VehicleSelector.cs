using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046D RID: 1133
	public class VehicleSelector : Singleton<VehicleSelector>
	{
		// Token: 0x06006219 RID: 25113 RVA: 0x001BE8DC File Offset: 0x001BCADC
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSelector()
		{
			Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "VehicleSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr);
			VehicleSelector.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "detectionRange");
			VehicleSelector.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "detectionMask");
			VehicleSelector.NativeFieldInfoPtr__isSelecting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "<isSelecting>k__BackingField");
			VehicleSelector.NativeFieldInfoPtr_selectedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "selectedVehicles");
			VehicleSelector.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "onClose");
			VehicleSelector.NativeFieldInfoPtr_selectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "selectionLimit");
			VehicleSelector.NativeFieldInfoPtr_exitOnSelectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "exitOnSelectionLimit");
			VehicleSelector.NativeFieldInfoPtr_hoveredVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "hoveredVehicle");
			VehicleSelector.NativeFieldInfoPtr_outlinedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "outlinedVehicles");
			VehicleSelector.NativeFieldInfoPtr_vehicleFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, "vehicleFilter");
			VehicleSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675753);
			VehicleSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675754);
			VehicleSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675755);
			VehicleSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675756);
			VehicleSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675757);
			VehicleSelector.NativeMethodInfoPtr_GetHoveredVehicle_Private_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675758);
			VehicleSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675759);
			VehicleSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_byref_List_1_LandVehicle_Int32_Boolean_Func_2_LandVehicle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675760);
			VehicleSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675761);
			VehicleSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr, 100675762);
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x0600621A RID: 25114 RVA: 0x001BEA9C File Offset: 0x001BCC9C
		// (set) Token: 0x0600621B RID: 25115 RVA: 0x001BEAD8 File Offset: 0x001BCCD8
		public unsafe bool isSelecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x001BEB18 File Offset: 0x001BCD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201664, XrefRangeEnd = 201677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x001BEB54 File Offset: 0x001BCD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201677, XrefRangeEnd = 201717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x001BEB90 File Offset: 0x001BCD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201717, XrefRangeEnd = 201746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x001BEBCC File Offset: 0x001BCDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201746, XrefRangeEnd = 201759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle GetHoveredVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_GetHoveredVehicle_Private_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x001BEC0C File Offset: 0x001BCE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201759, XrefRangeEnd = 201760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x001BEC50 File Offset: 0x001BCE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201760, XrefRangeEnd = 201786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSelecting(string selectionTitle, ref List<LandVehicle> initialSelection, int _selectionLimit, bool _exitOnSelectionLimit, Func<LandVehicle, bool> filter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(initialSelection);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _selectionLimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _exitOnSelectionLimit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_byref_List_1_LandVehicle_Int32_Boolean_Func_2_LandVehicle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			initialSelection = ((intPtr4 == 0) ? null : new List<LandVehicle>(intPtr4));
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x001BECE8 File Offset: 0x001BCEE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201806, RefRangeEnd = 201808, XrefRangeStart = 201786, XrefRangeEnd = 201806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSelecting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x001BED1C File Offset: 0x001BCF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201808, XrefRangeEnd = 201858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x0002E574 File Offset: 0x0002C774
		public VehicleSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06006225 RID: 25125 RVA: 0x001BED58 File Offset: 0x001BCF58
		// (set) Token: 0x06006226 RID: 25126 RVA: 0x0002E57D File Offset: 0x0002C77D
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06006227 RID: 25127 RVA: 0x001BED80 File Offset: 0x001BCF80
		// (set) Token: 0x06006228 RID: 25128 RVA: 0x0002E598 File Offset: 0x0002C798
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x06006229 RID: 25129 RVA: 0x001BEDA8 File Offset: 0x001BCFA8
		// (set) Token: 0x0600622A RID: 25130 RVA: 0x0002E5B3 File Offset: 0x0002C7B3
		public unsafe bool _isSelecting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr__isSelecting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr__isSelecting_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x0600622B RID: 25131 RVA: 0x001BEDD0 File Offset: 0x001BCFD0
		// (set) Token: 0x0600622C RID: 25132 RVA: 0x0002E5CE File Offset: 0x0002C7CE
		public unsafe List<LandVehicle> selectedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x0600622D RID: 25133 RVA: 0x001BEE00 File Offset: 0x001BD000
		// (set) Token: 0x0600622E RID: 25134 RVA: 0x0002E5ED File Offset: 0x0002C7ED
		public unsafe Action onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x0600622F RID: 25135 RVA: 0x001BEE30 File Offset: 0x001BD030
		// (set) Token: 0x06006230 RID: 25136 RVA: 0x0002E60C File Offset: 0x0002C80C
		public unsafe int selectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_selectionLimit)) = value;
			}
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06006231 RID: 25137 RVA: 0x001BEE58 File Offset: 0x001BD058
		// (set) Token: 0x06006232 RID: 25138 RVA: 0x0002E627 File Offset: 0x0002C827
		public unsafe bool exitOnSelectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_exitOnSelectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_exitOnSelectionLimit)) = value;
			}
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x06006233 RID: 25139 RVA: 0x001BEE80 File Offset: 0x001BD080
		// (set) Token: 0x06006234 RID: 25140 RVA: 0x0002E642 File Offset: 0x0002C842
		public unsafe LandVehicle hoveredVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_hoveredVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_hoveredVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x06006235 RID: 25141 RVA: 0x001BEEB0 File Offset: 0x001BD0B0
		// (set) Token: 0x06006236 RID: 25142 RVA: 0x0002E661 File Offset: 0x0002C861
		public unsafe List<LandVehicle> outlinedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_outlinedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_outlinedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x06006237 RID: 25143 RVA: 0x001BEEE0 File Offset: 0x001BD0E0
		// (set) Token: 0x06006238 RID: 25144 RVA: 0x0002E680 File Offset: 0x0002C880
		public unsafe Func<LandVehicle, bool> vehicleFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_vehicleFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LandVehicle, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSelector.NativeFieldInfoPtr_vehicleFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042E5 RID: 17125
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x040042E6 RID: 17126
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040042E7 RID: 17127
		private static readonly IntPtr NativeFieldInfoPtr__isSelecting_k__BackingField;

		// Token: 0x040042E8 RID: 17128
		private static readonly IntPtr NativeFieldInfoPtr_selectedVehicles;

		// Token: 0x040042E9 RID: 17129
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x040042EA RID: 17130
		private static readonly IntPtr NativeFieldInfoPtr_selectionLimit;

		// Token: 0x040042EB RID: 17131
		private static readonly IntPtr NativeFieldInfoPtr_exitOnSelectionLimit;

		// Token: 0x040042EC RID: 17132
		private static readonly IntPtr NativeFieldInfoPtr_hoveredVehicle;

		// Token: 0x040042ED RID: 17133
		private static readonly IntPtr NativeFieldInfoPtr_outlinedVehicles;

		// Token: 0x040042EE RID: 17134
		private static readonly IntPtr NativeFieldInfoPtr_vehicleFilter;

		// Token: 0x040042EF RID: 17135
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0;

		// Token: 0x040042F0 RID: 17136
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0;

		// Token: 0x040042F1 RID: 17137
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040042F2 RID: 17138
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040042F3 RID: 17139
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040042F4 RID: 17140
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredVehicle_Private_LandVehicle_0;

		// Token: 0x040042F5 RID: 17141
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040042F6 RID: 17142
		private static readonly IntPtr NativeMethodInfoPtr_StartSelecting_Public_Void_String_byref_List_1_LandVehicle_Int32_Boolean_Func_2_LandVehicle_Boolean_0;

		// Token: 0x040042F7 RID: 17143
		private static readonly IntPtr NativeMethodInfoPtr_StopSelecting_Public_Void_0;

		// Token: 0x040042F8 RID: 17144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
