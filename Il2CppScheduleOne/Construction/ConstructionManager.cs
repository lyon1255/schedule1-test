using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Construction;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Construction
{
	// Token: 0x02000480 RID: 1152
	public class ConstructionManager : Singleton<ConstructionManager>
	{
		// Token: 0x060063D3 RID: 25555 RVA: 0x001C4448 File Offset: 0x001C2648
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionManager()
		{
			Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction", "ConstructionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr);
			ConstructionManager.NativeFieldInfoPtr_networkObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "networkObject");
			ConstructionManager.NativeFieldInfoPtr__constructionModeEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "<constructionModeEnabled>k__BackingField");
			ConstructionManager.NativeFieldInfoPtr_onConstructionModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onConstructionModeEnabled");
			ConstructionManager.NativeFieldInfoPtr_onConstructionModeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onConstructionModeDisabled");
			ConstructionManager.NativeFieldInfoPtr__isDeployingConstructable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "<isDeployingConstructable>k__BackingField");
			ConstructionManager.NativeFieldInfoPtr_constructHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "constructHandler");
			ConstructionManager.NativeFieldInfoPtr__isMovingConstructable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "<isMovingConstructable>k__BackingField");
			ConstructionManager.NativeFieldInfoPtr_onNewConstructableBuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onNewConstructableBuilt");
			ConstructionManager.NativeFieldInfoPtr_onConstructableMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "onConstructableMoved");
			ConstructionManager.NativeFieldInfoPtr_currentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "currentProperty");
			ConstructionManager.NativeMethodInfoPtr_get_constructionModeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675949);
			ConstructionManager.NativeMethodInfoPtr_set_constructionModeEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675950);
			ConstructionManager.NativeMethodInfoPtr_get_isDeployingConstructable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675951);
			ConstructionManager.NativeMethodInfoPtr_set_isDeployingConstructable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675952);
			ConstructionManager.NativeMethodInfoPtr_get_isMovingConstructable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675953);
			ConstructionManager.NativeMethodInfoPtr_set_isMovingConstructable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675954);
			ConstructionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675955);
			ConstructionManager.NativeMethodInfoPtr_EnterConstructionMode_Public_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675956);
			ConstructionManager.NativeMethodInfoPtr_ExitConstructionMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675957);
			ConstructionManager.NativeMethodInfoPtr_DeployConstructable_Public_Void_ConstructionMenuListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675958);
			ConstructionManager.NativeMethodInfoPtr_StopConstructableDeploy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675959);
			ConstructionManager.NativeMethodInfoPtr_MoveConstructable_Public_Void_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675960);
			ConstructionManager.NativeMethodInfoPtr_StopMovingConstructable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675961);
			ConstructionManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675962);
			ConstructionManager.NativeMethodInfoPtr_CreateConstructable_GridBased_Public_Constructable_GridBased_String_Grid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675963);
			ConstructionManager.NativeMethodInfoPtr_CreateConstructable_Public_Constructable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675964);
			ConstructionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, 100675965);
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x060063D4 RID: 25556 RVA: 0x001C4694 File Offset: 0x001C2894
		// (set) Token: 0x060063D5 RID: 25557 RVA: 0x001C46D0 File Offset: 0x001C28D0
		public unsafe bool constructionModeEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_get_constructionModeEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_set_constructionModeEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x060063D6 RID: 25558 RVA: 0x001C4710 File Offset: 0x001C2910
		// (set) Token: 0x060063D7 RID: 25559 RVA: 0x001C474C File Offset: 0x001C294C
		public unsafe bool isDeployingConstructable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_get_isDeployingConstructable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50979, RefRangeEnd = 50982, XrefRangeStart = 50979, XrefRangeEnd = 50982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_set_isDeployingConstructable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x060063D8 RID: 25560 RVA: 0x001C478C File Offset: 0x001C298C
		// (set) Token: 0x060063D9 RID: 25561 RVA: 0x001C47C8 File Offset: 0x001C29C8
		public unsafe bool isMovingConstructable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_get_isMovingConstructable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_set_isMovingConstructable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x001C4808 File Offset: 0x001C2A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203701, XrefRangeEnd = 203714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x001C4844 File Offset: 0x001C2A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203730, RefRangeEnd = 203731, XrefRangeStart = 203714, XrefRangeEnd = 203730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterConstructionMode(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_EnterConstructionMode_Public_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x001C4888 File Offset: 0x001C2A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203752, RefRangeEnd = 203753, XrefRangeStart = 203731, XrefRangeEnd = 203752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitConstructionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_ExitConstructionMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x001C48BC File Offset: 0x001C2ABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 203776, RefRangeEnd = 203778, XrefRangeStart = 203753, XrefRangeEnd = 203776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeployConstructable(ConstructionMenu.ConstructionMenuListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_DeployConstructable_Public_Void_ConstructionMenuListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x001C4900 File Offset: 0x001C2B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203782, RefRangeEnd = 203783, XrefRangeStart = 203778, XrefRangeEnd = 203782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopConstructableDeploy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_StopConstructableDeploy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x001C4934 File Offset: 0x001C2B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203804, RefRangeEnd = 203805, XrefRangeStart = 203783, XrefRangeEnd = 203804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveConstructable(Constructable_GridBased c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_MoveConstructable_Public_Void_Constructable_GridBased_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x001C4978 File Offset: 0x001C2B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203805, XrefRangeEnd = 203809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopMovingConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_StopMovingConstructable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x001C49AC File Offset: 0x001C2BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203809, XrefRangeEnd = 203811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x001C49F0 File Offset: 0x001C2BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203811, XrefRangeEnd = 203823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable_GridBased CreateConstructable_GridBased(string ID, Grid grid, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_CreateConstructable_GridBased_Public_Constructable_GridBased_String_Grid_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr3) : null;
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x001C4A70 File Offset: 0x001C2C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203834, RefRangeEnd = 203835, XrefRangeStart = 203823, XrefRangeEnd = 203834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable CreateConstructable(string prefabID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr_CreateConstructable_Public_Constructable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x001C4AC0 File Offset: 0x001C2CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203835, XrefRangeEnd = 203838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x0002F34C File Offset: 0x0002D54C
		public ConstructionManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x060063E6 RID: 25574 RVA: 0x001C4AFC File Offset: 0x001C2CFC
		// (set) Token: 0x060063E7 RID: 25575 RVA: 0x0002F355 File Offset: 0x0002D555
		public unsafe NetworkObject networkObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_networkObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_networkObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x060063E8 RID: 25576 RVA: 0x001C4B2C File Offset: 0x001C2D2C
		// (set) Token: 0x060063E9 RID: 25577 RVA: 0x0002F374 File Offset: 0x0002D574
		public unsafe bool _constructionModeEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__constructionModeEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__constructionModeEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x060063EA RID: 25578 RVA: 0x001C4B54 File Offset: 0x001C2D54
		// (set) Token: 0x060063EB RID: 25579 RVA: 0x0002F38F File Offset: 0x0002D58F
		public unsafe Action onConstructionModeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x060063EC RID: 25580 RVA: 0x001C4B84 File Offset: 0x001C2D84
		// (set) Token: 0x060063ED RID: 25581 RVA: 0x0002F3AE File Offset: 0x0002D5AE
		public unsafe Action onConstructionModeDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructionModeDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x060063EE RID: 25582 RVA: 0x001C4BB4 File Offset: 0x001C2DB4
		// (set) Token: 0x060063EF RID: 25583 RVA: 0x0002F3CD File Offset: 0x0002D5CD
		public unsafe bool _isDeployingConstructable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isDeployingConstructable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isDeployingConstructable_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x060063F0 RID: 25584 RVA: 0x001C4BDC File Offset: 0x001C2DDC
		// (set) Token: 0x060063F1 RID: 25585 RVA: 0x0002F3E8 File Offset: 0x0002D5E8
		public unsafe GameObject constructHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_constructHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_constructHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x060063F2 RID: 25586 RVA: 0x001C4C0C File Offset: 0x001C2E0C
		// (set) Token: 0x060063F3 RID: 25587 RVA: 0x0002F407 File Offset: 0x0002D607
		public unsafe bool _isMovingConstructable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isMovingConstructable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr__isMovingConstructable_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x060063F4 RID: 25588 RVA: 0x001C4C34 File Offset: 0x001C2E34
		// (set) Token: 0x060063F5 RID: 25589 RVA: 0x0002F422 File Offset: 0x0002D622
		public unsafe ConstructionManager.ConstructableNotification onNewConstructableBuilt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onNewConstructableBuilt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionManager.ConstructableNotification>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onNewConstructableBuilt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x060063F6 RID: 25590 RVA: 0x001C4C64 File Offset: 0x001C2E64
		// (set) Token: 0x060063F7 RID: 25591 RVA: 0x0002F441 File Offset: 0x0002D641
		public unsafe ConstructionManager.ConstructableNotification onConstructableMoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructableMoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionManager.ConstructableNotification>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_onConstructableMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x060063F8 RID: 25592 RVA: 0x001C4C94 File Offset: 0x001C2E94
		// (set) Token: 0x060063F9 RID: 25593 RVA: 0x0002F460 File Offset: 0x0002D660
		public unsafe Property currentProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_currentProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.NativeFieldInfoPtr_currentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400441F RID: 17439
		private static readonly IntPtr NativeFieldInfoPtr_networkObject;

		// Token: 0x04004420 RID: 17440
		private static readonly IntPtr NativeFieldInfoPtr__constructionModeEnabled_k__BackingField;

		// Token: 0x04004421 RID: 17441
		private static readonly IntPtr NativeFieldInfoPtr_onConstructionModeEnabled;

		// Token: 0x04004422 RID: 17442
		private static readonly IntPtr NativeFieldInfoPtr_onConstructionModeDisabled;

		// Token: 0x04004423 RID: 17443
		private static readonly IntPtr NativeFieldInfoPtr__isDeployingConstructable_k__BackingField;

		// Token: 0x04004424 RID: 17444
		private static readonly IntPtr NativeFieldInfoPtr_constructHandler;

		// Token: 0x04004425 RID: 17445
		private static readonly IntPtr NativeFieldInfoPtr__isMovingConstructable_k__BackingField;

		// Token: 0x04004426 RID: 17446
		private static readonly IntPtr NativeFieldInfoPtr_onNewConstructableBuilt;

		// Token: 0x04004427 RID: 17447
		private static readonly IntPtr NativeFieldInfoPtr_onConstructableMoved;

		// Token: 0x04004428 RID: 17448
		private static readonly IntPtr NativeFieldInfoPtr_currentProperty;

		// Token: 0x04004429 RID: 17449
		private static readonly IntPtr NativeMethodInfoPtr_get_constructionModeEnabled_Public_get_Boolean_0;

		// Token: 0x0400442A RID: 17450
		private static readonly IntPtr NativeMethodInfoPtr_set_constructionModeEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x0400442B RID: 17451
		private static readonly IntPtr NativeMethodInfoPtr_get_isDeployingConstructable_Public_get_Boolean_0;

		// Token: 0x0400442C RID: 17452
		private static readonly IntPtr NativeMethodInfoPtr_set_isDeployingConstructable_Protected_set_Void_Boolean_0;

		// Token: 0x0400442D RID: 17453
		private static readonly IntPtr NativeMethodInfoPtr_get_isMovingConstructable_Public_get_Boolean_0;

		// Token: 0x0400442E RID: 17454
		private static readonly IntPtr NativeMethodInfoPtr_set_isMovingConstructable_Protected_set_Void_Boolean_0;

		// Token: 0x0400442F RID: 17455
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004430 RID: 17456
		private static readonly IntPtr NativeMethodInfoPtr_EnterConstructionMode_Public_Void_Property_0;

		// Token: 0x04004431 RID: 17457
		private static readonly IntPtr NativeMethodInfoPtr_ExitConstructionMode_Public_Void_0;

		// Token: 0x04004432 RID: 17458
		private static readonly IntPtr NativeMethodInfoPtr_DeployConstructable_Public_Void_ConstructionMenuListing_0;

		// Token: 0x04004433 RID: 17459
		private static readonly IntPtr NativeMethodInfoPtr_StopConstructableDeploy_Public_Void_0;

		// Token: 0x04004434 RID: 17460
		private static readonly IntPtr NativeMethodInfoPtr_MoveConstructable_Public_Void_Constructable_GridBased_0;

		// Token: 0x04004435 RID: 17461
		private static readonly IntPtr NativeMethodInfoPtr_StopMovingConstructable_Public_Void_0;

		// Token: 0x04004436 RID: 17462
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04004437 RID: 17463
		private static readonly IntPtr NativeMethodInfoPtr_CreateConstructable_GridBased_Public_Constructable_GridBased_String_Grid_Vector2_Single_0;

		// Token: 0x04004438 RID: 17464
		private static readonly IntPtr NativeMethodInfoPtr_CreateConstructable_Public_Constructable_String_0;

		// Token: 0x04004439 RID: 17465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A2A RID: 2602
		public class WorldIntersection : Il2CppSystem.Object
		{
			// Token: 0x0600CF3B RID: 53051 RVA: 0x0031CA74 File Offset: 0x0031AC74
			// Note: this type is marked as 'beforefieldinit'.
			static WorldIntersection()
			{
				Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "WorldIntersection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr);
				ConstructionManager.WorldIntersection.NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr, "footprint");
				ConstructionManager.WorldIntersection.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr, "tile");
				ConstructionManager.WorldIntersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr, 100675966);
			}

			// Token: 0x0600CF3C RID: 53052 RVA: 0x0031CADC File Offset: 0x0031ACDC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorldIntersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionManager.WorldIntersection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.WorldIntersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF3D RID: 53053 RVA: 0x00064CF2 File Offset: 0x00062EF2
			public WorldIntersection(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004069 RID: 16489
			// (get) Token: 0x0600CF3E RID: 53054 RVA: 0x0031CB18 File Offset: 0x0031AD18
			// (set) Token: 0x0600CF3F RID: 53055 RVA: 0x00064CFB File Offset: 0x00062EFB
			public unsafe FootprintTile footprint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_footprint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_footprint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406A RID: 16490
			// (get) Token: 0x0600CF40 RID: 53056 RVA: 0x0031CB48 File Offset: 0x0031AD48
			// (set) Token: 0x0600CF41 RID: 53057 RVA: 0x00064D1A File Offset: 0x00062F1A
			public unsafe Tile tile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_tile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionManager.WorldIntersection.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BD1 RID: 35793
			private static readonly IntPtr NativeFieldInfoPtr_footprint;

			// Token: 0x04008BD2 RID: 35794
			private static readonly IntPtr NativeFieldInfoPtr_tile;

			// Token: 0x04008BD3 RID: 35795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A2B RID: 2603
		public sealed class ConstructableNotification : MulticastDelegate
		{
			// Token: 0x0600CF42 RID: 53058 RVA: 0x0031CB78 File Offset: 0x0031AD78
			// Note: this type is marked as 'beforefieldinit'.
			static ConstructableNotification()
			{
				Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionManager>.NativeClassPtr, "ConstructableNotification");
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100675967);
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100675968);
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Constructable_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100675969);
				ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr, 100675970);
			}

			// Token: 0x0600CF43 RID: 53059 RVA: 0x0031CBEC File Offset: 0x0031ADEC
			[CallerCount(632)]
			[CachedScanResults(RefRangeStart = 81883, RefRangeEnd = 82515, XrefRangeStart = 81883, XrefRangeEnd = 82515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstructableNotification(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionManager.ConstructableNotification>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF44 RID: 53060 RVA: 0x0031CC48 File Offset: 0x0031AE48
			[CallerCount(0)]
			public unsafe void Invoke(Constructable c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF45 RID: 53061 RVA: 0x0031CC8C File Offset: 0x0031AE8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Constructable c, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Constructable_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CF46 RID: 53062 RVA: 0x0031CD00 File Offset: 0x0031AF00
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionManager.ConstructableNotification.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF47 RID: 53063 RVA: 0x00064D39 File Offset: 0x00062F39
			public ConstructableNotification(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CF48 RID: 53064 RVA: 0x00064D42 File Offset: 0x00062F42
			public static implicit operator ConstructionManager.ConstructableNotification(Action<Constructable> A_0)
			{
				return DelegateSupport.ConvertDelegate<ConstructionManager.ConstructableNotification>(A_0);
			}

			// Token: 0x0600CF49 RID: 53065 RVA: 0x00064D4A File Offset: 0x00062F4A
			public static ConstructionManager.ConstructableNotification operator +(ConstructionManager.ConstructableNotification A_0, ConstructionManager.ConstructableNotification A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ConstructionManager.ConstructableNotification>();
			}

			// Token: 0x0600CF4A RID: 53066 RVA: 0x00064D58 File Offset: 0x00062F58
			public static ConstructionManager.ConstructableNotification operator -(ConstructionManager.ConstructableNotification A_0, ConstructionManager.ConstructableNotification A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<ConstructionManager.ConstructableNotification>();
				}
				return result;
			}

			// Token: 0x04008BD4 RID: 35796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008BD5 RID: 35797
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Constructable_0;

			// Token: 0x04008BD6 RID: 35798
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Constructable_AsyncCallback_Object_0;

			// Token: 0x04008BD7 RID: 35799
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
