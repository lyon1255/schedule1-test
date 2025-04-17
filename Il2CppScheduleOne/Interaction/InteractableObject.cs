using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x020003EF RID: 1007
	public class InteractableObject : MonoBehaviour
	{
		// Token: 0x0600533D RID: 21309 RVA: 0x00188814 File Offset: 0x00186A14
		// Note: this type is marked as 'beforefieldinit'.
		static InteractableObject()
		{
			Il2CppClassPointerStore<InteractableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr);
			InteractableObject.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "message");
			InteractableObject.NativeFieldInfoPtr_interactionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "interactionType");
			InteractableObject.NativeFieldInfoPtr_interactionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "interactionState");
			InteractableObject.NativeFieldInfoPtr_MaxInteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "MaxInteractionRange");
			InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "RequiresUniqueClick");
			InteractableObject.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "Priority");
			InteractableObject.NativeFieldInfoPtr_displayLocationCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "displayLocationCollider");
			InteractableObject.NativeFieldInfoPtr_displayLocationPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "displayLocationPoint");
			InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "LimitInteractionAngle");
			InteractableObject.NativeFieldInfoPtr_AngleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "AngleLimit");
			InteractableObject.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onHovered");
			InteractableObject.NativeFieldInfoPtr_onInteractStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onInteractStart");
			InteractableObject.NativeFieldInfoPtr_onInteractEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onInteractEnd");
			InteractableObject.NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673711);
			InteractableObject.NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673712);
			InteractableObject.NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673713);
			InteractableObject.NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673714);
			InteractableObject.NativeMethodInfoPtr_SetMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673715);
			InteractableObject.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673716);
			InteractableObject.NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673717);
			InteractableObject.NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673718);
			InteractableObject.NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673719);
			InteractableObject.NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673720);
			InteractableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100673721);
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x0600533E RID: 21310 RVA: 0x00188A24 File Offset: 0x00186C24
		public unsafe InteractableObject.EInteractionType _interactionType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29987, RefRangeEnd = 29988, XrefRangeStart = 29987, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x0600533F RID: 21311 RVA: 0x00188A60 File Offset: 0x00186C60
		public unsafe InteractableObject.EInteractableState _interactionState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x00188A9C File Offset: 0x00186C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractionType(InteractableObject.EInteractionType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x00188ADC File Offset: 0x00186CDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178835, RefRangeEnd = 178836, XrefRangeStart = 178835, XrefRangeEnd = 178836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractableState(InteractableObject.EInteractableState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x00188B1C File Offset: 0x00186D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessage(string _message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x00188B60 File Offset: 0x00186D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178848, RefRangeEnd = 178849, XrefRangeStart = 178847, XrefRangeEnd = 178848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x00188B9C File Offset: 0x00186D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178855, RefRangeEnd = 178856, XrefRangeStart = 178849, XrefRangeEnd = 178855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x00188BD8 File Offset: 0x00186DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178856, XrefRangeEnd = 178863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x00188C14 File Offset: 0x00186E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178863, XrefRangeEnd = 178891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005347 RID: 21319 RVA: 0x00188C50 File Offset: 0x00186E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178900, RefRangeEnd = 178901, XrefRangeStart = 178891, XrefRangeEnd = 178900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAngleLimit(Vector3 interactionSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactionSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x00188C9C File Offset: 0x00186E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178919, RefRangeEnd = 178920, XrefRangeStart = 178901, XrefRangeEnd = 178919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x00027B2A File Offset: 0x00025D2A
		public InteractableObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x0600534A RID: 21322 RVA: 0x00188CD8 File Offset: 0x00186ED8
		// (set) Token: 0x0600534B RID: 21323 RVA: 0x00027B33 File Offset: 0x00025D33
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x0600534C RID: 21324 RVA: 0x00188D00 File Offset: 0x00186F00
		// (set) Token: 0x0600534D RID: 21325 RVA: 0x00027B52 File Offset: 0x00025D52
		public unsafe InteractableObject.EInteractionType interactionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionType)) = value;
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x0600534E RID: 21326 RVA: 0x00188D28 File Offset: 0x00186F28
		// (set) Token: 0x0600534F RID: 21327 RVA: 0x00027B6D File Offset: 0x00025D6D
		public unsafe InteractableObject.EInteractableState interactionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionState)) = value;
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x00188D50 File Offset: 0x00186F50
		// (set) Token: 0x06005351 RID: 21329 RVA: 0x00027B88 File Offset: 0x00025D88
		public unsafe float MaxInteractionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_MaxInteractionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_MaxInteractionRange)) = value;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x06005352 RID: 21330 RVA: 0x00188D78 File Offset: 0x00186F78
		// (set) Token: 0x06005353 RID: 21331 RVA: 0x00027BA3 File Offset: 0x00025DA3
		public unsafe bool RequiresUniqueClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick)) = value;
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x06005354 RID: 21332 RVA: 0x00188DA0 File Offset: 0x00186FA0
		// (set) Token: 0x06005355 RID: 21333 RVA: 0x00027BBE File Offset: 0x00025DBE
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06005356 RID: 21334 RVA: 0x00188DC8 File Offset: 0x00186FC8
		// (set) Token: 0x06005357 RID: 21335 RVA: 0x00027BD9 File Offset: 0x00025DD9
		public unsafe Collider displayLocationCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06005358 RID: 21336 RVA: 0x00188DF8 File Offset: 0x00186FF8
		// (set) Token: 0x06005359 RID: 21337 RVA: 0x00027BF8 File Offset: 0x00025DF8
		public unsafe Transform displayLocationPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x0600535A RID: 21338 RVA: 0x00188E28 File Offset: 0x00187028
		// (set) Token: 0x0600535B RID: 21339 RVA: 0x00027C17 File Offset: 0x00025E17
		public unsafe bool LimitInteractionAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle)) = value;
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x0600535C RID: 21340 RVA: 0x00188E50 File Offset: 0x00187050
		// (set) Token: 0x0600535D RID: 21341 RVA: 0x00027C32 File Offset: 0x00025E32
		public unsafe float AngleLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_AngleLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_AngleLimit)) = value;
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x0600535E RID: 21342 RVA: 0x00188E78 File Offset: 0x00187078
		// (set) Token: 0x0600535F RID: 21343 RVA: 0x00027C4D File Offset: 0x00025E4D
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06005360 RID: 21344 RVA: 0x00188EA8 File Offset: 0x001870A8
		// (set) Token: 0x06005361 RID: 21345 RVA: 0x00027C6C File Offset: 0x00025E6C
		public unsafe UnityEvent onInteractStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x00188ED8 File Offset: 0x001870D8
		// (set) Token: 0x06005363 RID: 21347 RVA: 0x00027C8B File Offset: 0x00025E8B
		public unsafe UnityEvent onInteractEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003871 RID: 14449
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04003872 RID: 14450
		private static readonly IntPtr NativeFieldInfoPtr_interactionType;

		// Token: 0x04003873 RID: 14451
		private static readonly IntPtr NativeFieldInfoPtr_interactionState;

		// Token: 0x04003874 RID: 14452
		private static readonly IntPtr NativeFieldInfoPtr_MaxInteractionRange;

		// Token: 0x04003875 RID: 14453
		private static readonly IntPtr NativeFieldInfoPtr_RequiresUniqueClick;

		// Token: 0x04003876 RID: 14454
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04003877 RID: 14455
		private static readonly IntPtr NativeFieldInfoPtr_displayLocationCollider;

		// Token: 0x04003878 RID: 14456
		private static readonly IntPtr NativeFieldInfoPtr_displayLocationPoint;

		// Token: 0x04003879 RID: 14457
		private static readonly IntPtr NativeFieldInfoPtr_LimitInteractionAngle;

		// Token: 0x0400387A RID: 14458
		private static readonly IntPtr NativeFieldInfoPtr_AngleLimit;

		// Token: 0x0400387B RID: 14459
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x0400387C RID: 14460
		private static readonly IntPtr NativeFieldInfoPtr_onInteractStart;

		// Token: 0x0400387D RID: 14461
		private static readonly IntPtr NativeFieldInfoPtr_onInteractEnd;

		// Token: 0x0400387E RID: 14462
		private static readonly IntPtr NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0;

		// Token: 0x0400387F RID: 14463
		private static readonly IntPtr NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0;

		// Token: 0x04003880 RID: 14464
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0;

		// Token: 0x04003881 RID: 14465
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0;

		// Token: 0x04003882 RID: 14466
		private static readonly IntPtr NativeMethodInfoPtr_SetMessage_Public_Void_String_0;

		// Token: 0x04003883 RID: 14467
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x04003884 RID: 14468
		private static readonly IntPtr NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0;

		// Token: 0x04003885 RID: 14469
		private static readonly IntPtr NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0;

		// Token: 0x04003886 RID: 14470
		private static readonly IntPtr NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0;

		// Token: 0x04003887 RID: 14471
		private static readonly IntPtr NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0;

		// Token: 0x04003888 RID: 14472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009B1 RID: 2481
		[OriginalName("Assembly-CSharp.dll", "", "EInteractionType")]
		public enum EInteractionType
		{
			// Token: 0x040089C0 RID: 35264
			Key_Press,
			// Token: 0x040089C1 RID: 35265
			LeftMouse_Click
		}

		// Token: 0x020009B2 RID: 2482
		[OriginalName("Assembly-CSharp.dll", "", "EInteractableState")]
		public enum EInteractableState
		{
			// Token: 0x040089C3 RID: 35267
			Default,
			// Token: 0x040089C4 RID: 35268
			Invalid,
			// Token: 0x040089C5 RID: 35269
			Disabled,
			// Token: 0x040089C6 RID: 35270
			Label
		}
	}
}
