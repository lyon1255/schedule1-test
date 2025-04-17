using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006A1 RID: 1697
	public class CallInterface : Singleton<CallInterface>
	{
		// Token: 0x06009782 RID: 38786 RVA: 0x0026B948 File Offset: 0x00269B48
		// Note: this type is marked as 'beforefieldinit'.
		static CallInterface()
		{
			Il2CppClassPointerStore<CallInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CallInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface>.NativeClassPtr);
			CallInterface.NativeFieldInfoPtr_TIME_PER_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "TIME_PER_CHAR");
			CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<ActiveCallData>k__BackingField");
			CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CallInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Canvas");
			CallInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Container");
			CallInterface.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "ProfilePicture");
			CallInterface.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "NameLabel");
			CallInterface.NativeFieldInfoPtr_MainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "MainText");
			CallInterface.NativeFieldInfoPtr_ContinuePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "ContinuePrompt");
			CallInterface.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "OpenAnim");
			CallInterface.NativeFieldInfoPtr_TypewriterEffectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "TypewriterEffectSound");
			CallInterface.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "CanvasGroup");
			CallInterface.NativeFieldInfoPtr_Highlight1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Highlight1Color");
			CallInterface.NativeFieldInfoPtr_currentCallStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "currentCallStage");
			CallInterface.NativeFieldInfoPtr_slideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "slideRoutine");
			CallInterface.NativeFieldInfoPtr_skipRollout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "skipRollout");
			CallInterface.NativeFieldInfoPtr_rolloutRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "rolloutRoutine");
			CallInterface.NativeFieldInfoPtr_highlight1Hex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "highlight1Hex");
			CallInterface.NativeFieldInfoPtr_CallCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "CallCompleted");
			CallInterface.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100681994);
			CallInterface.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100681995);
			CallInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100681996);
			CallInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100681997);
			CallInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100681998);
			CallInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100681999);
			CallInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682000);
			CallInterface.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682001);
			CallInterface.NativeMethodInfoPtr_EndCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682002);
			CallInterface.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682003);
			CallInterface.NativeMethodInfoPtr_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682004);
			CallInterface.NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682005);
			CallInterface.NativeMethodInfoPtr_ProcessText_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682006);
			CallInterface.NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682007);
			CallInterface.NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682008);
			CallInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682009);
			CallInterface.NativeMethodInfoPtr__ProcessText_b__33_0_Private_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682010);
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x06009783 RID: 38787 RVA: 0x0026BC48 File Offset: 0x00269E48
		// (set) Token: 0x06009784 RID: 38788 RVA: 0x0026BC88 File Offset: 0x00269E88
		public unsafe PhoneCallData ActiveCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x06009785 RID: 38789 RVA: 0x0026BCCC File Offset: 0x00269ECC
		// (set) Token: 0x06009786 RID: 38790 RVA: 0x0026BD08 File Offset: 0x00269F08
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009787 RID: 38791 RVA: 0x0026BD48 File Offset: 0x00269F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271020, XrefRangeEnd = 271041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009788 RID: 38792 RVA: 0x0026BD84 File Offset: 0x00269F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271041, XrefRangeEnd = 271065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009789 RID: 38793 RVA: 0x0026BDB8 File Offset: 0x00269FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271065, XrefRangeEnd = 271066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x0026BDFC File Offset: 0x00269FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271123, RefRangeEnd = 271124, XrefRangeStart = 271066, XrefRangeEnd = 271123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCall(PhoneCallData data, CallerID caller, int startStage = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caller);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startStage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x0026BE60 File Offset: 0x0026A060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271124, XrefRangeEnd = 271137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_EndCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x0026BE94 File Offset: 0x0026A094
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 271185, RefRangeEnd = 271189, XrefRangeStart = 271137, XrefRangeEnd = 271185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x0026BEC8 File Offset: 0x0026A0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271189, XrefRangeEnd = 271205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x0026BEFC File Offset: 0x0026A0FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271220, RefRangeEnd = 271223, XrefRangeStart = 271205, XrefRangeEnd = 271220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowStage(int stageIndex, float initialDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stageIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600978F RID: 38799 RVA: 0x0026BF48 File Offset: 0x0026A148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271223, XrefRangeEnd = 271249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ProcessText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_ProcessText_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009790 RID: 38800 RVA: 0x0026BF90 File Offset: 0x0026A190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271249, XrefRangeEnd = 271251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetVisibleText(int charactersShown, string fullText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref charactersShown;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009791 RID: 38801 RVA: 0x0026BFE8 File Offset: 0x0026A1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271251, XrefRangeEnd = 271261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009792 RID: 38802 RVA: 0x0026C028 File Offset: 0x0026A228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271261, XrefRangeEnd = 271264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009793 RID: 38803 RVA: 0x0026C064 File Offset: 0x0026A264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271264, XrefRangeEnd = 271279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _ProcessText_b__33_0(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr__ProcessText_b__33_0_Private_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x00049ABF File Offset: 0x00047CBF
		public CallInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x06009795 RID: 38805 RVA: 0x0026C0AC File Offset: 0x0026A2AC
		// (set) Token: 0x06009796 RID: 38806 RVA: 0x00049AC8 File Offset: 0x00047CC8
		public unsafe static float TIME_PER_CHAR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallInterface.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallInterface.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&value));
			}
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x06009797 RID: 38807 RVA: 0x0026C0C8 File Offset: 0x0026A2C8
		// (set) Token: 0x06009798 RID: 38808 RVA: 0x00049AD6 File Offset: 0x00047CD6
		public unsafe PhoneCallData _ActiveCallData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x06009799 RID: 38809 RVA: 0x0026C0F8 File Offset: 0x0026A2F8
		// (set) Token: 0x0600979A RID: 38810 RVA: 0x00049AF5 File Offset: 0x00047CF5
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x0600979B RID: 38811 RVA: 0x0026C120 File Offset: 0x0026A320
		// (set) Token: 0x0600979C RID: 38812 RVA: 0x00049B10 File Offset: 0x00047D10
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x0600979D RID: 38813 RVA: 0x0026C150 File Offset: 0x0026A350
		// (set) Token: 0x0600979E RID: 38814 RVA: 0x00049B2F File Offset: 0x00047D2F
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x0600979F RID: 38815 RVA: 0x0026C180 File Offset: 0x0026A380
		// (set) Token: 0x060097A0 RID: 38816 RVA: 0x00049B4E File Offset: 0x00047D4E
		public unsafe Image ProfilePicture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ProfilePicture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x060097A1 RID: 38817 RVA: 0x0026C1B0 File Offset: 0x0026A3B0
		// (set) Token: 0x060097A2 RID: 38818 RVA: 0x00049B6D File Offset: 0x00047D6D
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x060097A3 RID: 38819 RVA: 0x0026C1E0 File Offset: 0x0026A3E0
		// (set) Token: 0x060097A4 RID: 38820 RVA: 0x00049B8C File Offset: 0x00047D8C
		public unsafe TextMeshProUGUI MainText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_MainText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_MainText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x060097A5 RID: 38821 RVA: 0x0026C210 File Offset: 0x0026A410
		// (set) Token: 0x060097A6 RID: 38822 RVA: 0x00049BAB File Offset: 0x00047DAB
		public unsafe RectTransform ContinuePrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ContinuePrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ContinuePrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x060097A7 RID: 38823 RVA: 0x0026C240 File Offset: 0x0026A440
		// (set) Token: 0x060097A8 RID: 38824 RVA: 0x00049BCA File Offset: 0x00047DCA
		public unsafe Animation OpenAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_OpenAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x060097A9 RID: 38825 RVA: 0x0026C270 File Offset: 0x0026A470
		// (set) Token: 0x060097AA RID: 38826 RVA: 0x00049BE9 File Offset: 0x00047DE9
		public unsafe AudioSourceController TypewriterEffectSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_TypewriterEffectSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_TypewriterEffectSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x060097AB RID: 38827 RVA: 0x0026C2A0 File Offset: 0x0026A4A0
		// (set) Token: 0x060097AC RID: 38828 RVA: 0x00049C08 File Offset: 0x00047E08
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x060097AD RID: 38829 RVA: 0x0026C2D0 File Offset: 0x0026A4D0
		// (set) Token: 0x060097AE RID: 38830 RVA: 0x00049C27 File Offset: 0x00047E27
		public unsafe Color Highlight1Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Highlight1Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Highlight1Color)) = value;
			}
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x060097AF RID: 38831 RVA: 0x0026C2F8 File Offset: 0x0026A4F8
		// (set) Token: 0x060097B0 RID: 38832 RVA: 0x00049C42 File Offset: 0x00047E42
		public unsafe int currentCallStage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_currentCallStage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_currentCallStage)) = value;
			}
		}

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x060097B1 RID: 38833 RVA: 0x0026C320 File Offset: 0x0026A520
		// (set) Token: 0x060097B2 RID: 38834 RVA: 0x00049C5D File Offset: 0x00047E5D
		public unsafe Coroutine slideRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_slideRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_slideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x060097B3 RID: 38835 RVA: 0x0026C350 File Offset: 0x0026A550
		// (set) Token: 0x060097B4 RID: 38836 RVA: 0x00049C7C File Offset: 0x00047E7C
		public unsafe bool skipRollout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_skipRollout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_skipRollout)) = value;
			}
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x060097B5 RID: 38837 RVA: 0x0026C378 File Offset: 0x0026A578
		// (set) Token: 0x060097B6 RID: 38838 RVA: 0x00049C97 File Offset: 0x00047E97
		public unsafe Coroutine rolloutRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_rolloutRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_rolloutRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x060097B7 RID: 38839 RVA: 0x0026C3A8 File Offset: 0x0026A5A8
		// (set) Token: 0x060097B8 RID: 38840 RVA: 0x00049CB6 File Offset: 0x00047EB6
		public unsafe string highlight1Hex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_highlight1Hex);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_highlight1Hex), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x060097B9 RID: 38841 RVA: 0x0026C3D0 File Offset: 0x0026A5D0
		// (set) Token: 0x060097BA RID: 38842 RVA: 0x00049CD5 File Offset: 0x00047ED5
		public unsafe Action<PhoneCallData> CallCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PhoneCallData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006614 RID: 26132
		private static readonly IntPtr NativeFieldInfoPtr_TIME_PER_CHAR;

		// Token: 0x04006615 RID: 26133
		private static readonly IntPtr NativeFieldInfoPtr__ActiveCallData_k__BackingField;

		// Token: 0x04006616 RID: 26134
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006617 RID: 26135
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006618 RID: 26136
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006619 RID: 26137
		private static readonly IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x0400661A RID: 26138
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x0400661B RID: 26139
		private static readonly IntPtr NativeFieldInfoPtr_MainText;

		// Token: 0x0400661C RID: 26140
		private static readonly IntPtr NativeFieldInfoPtr_ContinuePrompt;

		// Token: 0x0400661D RID: 26141
		private static readonly IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x0400661E RID: 26142
		private static readonly IntPtr NativeFieldInfoPtr_TypewriterEffectSound;

		// Token: 0x0400661F RID: 26143
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04006620 RID: 26144
		private static readonly IntPtr NativeFieldInfoPtr_Highlight1Color;

		// Token: 0x04006621 RID: 26145
		private static readonly IntPtr NativeFieldInfoPtr_currentCallStage;

		// Token: 0x04006622 RID: 26146
		private static readonly IntPtr NativeFieldInfoPtr_slideRoutine;

		// Token: 0x04006623 RID: 26147
		private static readonly IntPtr NativeFieldInfoPtr_skipRollout;

		// Token: 0x04006624 RID: 26148
		private static readonly IntPtr NativeFieldInfoPtr_rolloutRoutine;

		// Token: 0x04006625 RID: 26149
		private static readonly IntPtr NativeFieldInfoPtr_highlight1Hex;

		// Token: 0x04006626 RID: 26150
		private static readonly IntPtr NativeFieldInfoPtr_CallCompleted;

		// Token: 0x04006627 RID: 26151
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0;

		// Token: 0x04006628 RID: 26152
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x04006629 RID: 26153
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400662A RID: 26154
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400662B RID: 26155
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400662C RID: 26156
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400662D RID: 26157
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400662E RID: 26158
		private static readonly IntPtr NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0;

		// Token: 0x0400662F RID: 26159
		private static readonly IntPtr NativeMethodInfoPtr_EndCall_Public_Void_0;

		// Token: 0x04006630 RID: 26160
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04006631 RID: 26161
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Public_Void_0;

		// Token: 0x04006632 RID: 26162
		private static readonly IntPtr NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0;

		// Token: 0x04006633 RID: 26163
		private static readonly IntPtr NativeMethodInfoPtr_ProcessText_Private_String_String_0;

		// Token: 0x04006634 RID: 26164
		private static readonly IntPtr NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0;

		// Token: 0x04006635 RID: 26165
		private static readonly IntPtr NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0;

		// Token: 0x04006636 RID: 26166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006637 RID: 26167
		private static readonly IntPtr NativeMethodInfoPtr__ProcessText_b__33_0_Private_String_Match_0;

		// Token: 0x02000B67 RID: 2919
		[ObfuscatedName("ScheduleOne.UI.Phone.CallInterface+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA8B RID: 55947 RVA: 0x0033CA30 File Offset: 0x0033AC30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr);
				CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_initialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "initialDelay");
				CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_stageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "stageIndex");
				CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, 100682011);
				CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, 100682012);
			}

			// Token: 0x0600DA8C RID: 55948 RVA: 0x0033CAC0 File Offset: 0x0033ACC0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA8D RID: 55949 RVA: 0x0033CAFC File Offset: 0x0033ACFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271015, XrefRangeEnd = 271020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DA8E RID: 55950 RVA: 0x0006A6AF File Offset: 0x000688AF
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C9 RID: 17353
			// (get) Token: 0x0600DA8F RID: 55951 RVA: 0x0033CB3C File Offset: 0x0033AD3C
			// (set) Token: 0x0600DA90 RID: 55952 RVA: 0x0006A6B8 File Offset: 0x000688B8
			public unsafe CallInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CA RID: 17354
			// (get) Token: 0x0600DA91 RID: 55953 RVA: 0x0033CB6C File Offset: 0x0033AD6C
			// (set) Token: 0x0600DA92 RID: 55954 RVA: 0x0006A6D7 File Offset: 0x000688D7
			public unsafe float initialDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_initialDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_initialDelay)) = value;
				}
			}

			// Token: 0x170043CB RID: 17355
			// (get) Token: 0x0600DA93 RID: 55955 RVA: 0x0033CB94 File Offset: 0x0033AD94
			// (set) Token: 0x0600DA94 RID: 55956 RVA: 0x0006A6F2 File Offset: 0x000688F2
			public unsafe int stageIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_stageIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_stageIndex)) = value;
				}
			}

			// Token: 0x040092AE RID: 37550
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092AF RID: 37551
			private static readonly IntPtr NativeFieldInfoPtr_initialDelay;

			// Token: 0x040092B0 RID: 37552
			private static readonly IntPtr NativeFieldInfoPtr_stageIndex;

			// Token: 0x040092B1 RID: 37553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092B2 RID: 37554
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C79 RID: 3193
			[ObfuscatedName("ScheduleOne.UI.Phone.CallInterface+<>c__DisplayClass32_0+<<ShowStage>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E5DC RID: 58844 RVA: 0x0035D1B8 File Offset: 0x0035B3B8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique()
				{
					Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "<<ShowStage>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>1__state");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>2__current");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>4__this");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<stageText>5__2");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<parsedLength>5__3");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<i>5__4");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682013);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682014);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682015);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682016);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682017);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682018);
				}

				// Token: 0x0600E5DD RID: 58845 RVA: 0x0035D2D4 File Offset: 0x0035B4D4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5DE RID: 58846 RVA: 0x0035D31C File Offset: 0x0035B51C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5DF RID: 58847 RVA: 0x0035D350 File Offset: 0x0035B550
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270974, XrefRangeEnd = 271010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004789 RID: 18313
				// (get) Token: 0x0600E5E0 RID: 58848 RVA: 0x0035D38C File Offset: 0x0035B58C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5E1 RID: 58849 RVA: 0x0035D3CC File Offset: 0x0035B5CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271010, XrefRangeEnd = 271015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700478A RID: 18314
				// (get) Token: 0x0600E5E2 RID: 58850 RVA: 0x0035D400 File Offset: 0x0035B600
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5E3 RID: 58851 RVA: 0x00070292 File Offset: 0x0006E492
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004783 RID: 18307
				// (get) Token: 0x0600E5E4 RID: 58852 RVA: 0x0035D440 File Offset: 0x0035B640
				// (set) Token: 0x0600E5E5 RID: 58853 RVA: 0x0007029B File Offset: 0x0006E49B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004784 RID: 18308
				// (get) Token: 0x0600E5E6 RID: 58854 RVA: 0x0035D468 File Offset: 0x0035B668
				// (set) Token: 0x0600E5E7 RID: 58855 RVA: 0x000702B6 File Offset: 0x0006E4B6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004785 RID: 18309
				// (get) Token: 0x0600E5E8 RID: 58856 RVA: 0x0035D498 File Offset: 0x0035B698
				// (set) Token: 0x0600E5E9 RID: 58857 RVA: 0x000702D5 File Offset: 0x0006E4D5
				public unsafe CallInterface.__c__DisplayClass32_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallInterface.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004786 RID: 18310
				// (get) Token: 0x0600E5EA RID: 58858 RVA: 0x0035D4C8 File Offset: 0x0035B6C8
				// (set) Token: 0x0600E5EB RID: 58859 RVA: 0x000702F4 File Offset: 0x0006E4F4
				public unsafe string _stageText_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004787 RID: 18311
				// (get) Token: 0x0600E5EC RID: 58860 RVA: 0x0035D4F0 File Offset: 0x0035B6F0
				// (set) Token: 0x0600E5ED RID: 58861 RVA: 0x00070313 File Offset: 0x0006E513
				public unsafe int _parsedLength_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3)) = value;
					}
				}

				// Token: 0x17004788 RID: 18312
				// (get) Token: 0x0600E5EE RID: 58862 RVA: 0x0035D518 File Offset: 0x0035B718
				// (set) Token: 0x0600E5EF RID: 58863 RVA: 0x0007032E File Offset: 0x0006E52E
				public unsafe int _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x040099AA RID: 39338
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099AB RID: 39339
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099AC RID: 39340
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099AD RID: 39341
				private static readonly IntPtr NativeFieldInfoPtr__stageText_5__2;

				// Token: 0x040099AE RID: 39342
				private static readonly IntPtr NativeFieldInfoPtr__parsedLength_5__3;

				// Token: 0x040099AF RID: 39343
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x040099B0 RID: 39344
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099B1 RID: 39345
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099B2 RID: 39346
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099B3 RID: 39347
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099B4 RID: 39348
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099B5 RID: 39349
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
