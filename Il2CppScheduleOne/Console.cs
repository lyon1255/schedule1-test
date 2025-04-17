using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x02000167 RID: 359
	public class Console : Singleton<Console>
	{
		// Token: 0x06001CEB RID: 7403 RVA: 0x000CA1BC File Offset: 0x000C83BC
		// Note: this type is marked as 'beforefieldinit'.
		static Console()
		{
			Il2CppClassPointerStore<Console>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "Console");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console>.NativeClassPtr);
			Console.NativeFieldInfoPtr_TeleportPointsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "TeleportPointsContainer");
			Console.NativeFieldInfoPtr_LabelledGameObjectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "LabelledGameObjectList");
			Console.NativeFieldInfoPtr_startupCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "startupCommands");
			Console.NativeFieldInfoPtr_Commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "Commands");
			Console.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "commands");
			Console.NativeFieldInfoPtr_keyBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "keyBindings");
			Console.NativeMethodInfoPtr_get_player_Private_Static_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666322);
			Console.NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666323);
			Console.NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666324);
			Console.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666325);
			Console.NativeMethodInfoPtr_RunStartupCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666326);
			Console.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666327);
			Console.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666328);
			Console.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666329);
			Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666330);
			Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666331);
			Console.NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666332);
			Console.NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666333);
			Console.NativeMethodInfoPtr_ClearBindings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666334);
			Console.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666335);
			Console.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666336);
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000CA390 File Offset: 0x000C8590
		public unsafe static Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102757, XrefRangeEnd = 102761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_player_Private_Static_get_Player_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000CA3C4 File Offset: 0x000C85C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 102768, RefRangeEnd = 102773, XrefRangeStart = 102761, XrefRangeEnd = 102768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogCommandError(string error)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000CA3FC File Offset: 0x000C85FC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 102794, RefRangeEnd = 102805, XrefRangeStart = 102773, XrefRangeEnd = 102794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogUnrecognizedFormat(Il2CppStringArray correctExamples)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(correctExamples);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x000CA434 File Offset: 0x000C8634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102805, XrefRangeEnd = 103261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000CA470 File Offset: 0x000C8670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103261, XrefRangeEnd = 103287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunStartupCommands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_RunStartupCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000CA4A4 File Offset: 0x000C86A4
		[CallerCount(303)]
		[CachedScanResults(RefRangeStart = 103291, RefRangeEnd = 103594, XrefRangeStart = 103287, XrefRangeEnd = 103291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000CA4EC File Offset: 0x000C86EC
		[CallerCount(275)]
		[CachedScanResults(RefRangeStart = 103598, RefRangeEnd = 103873, XrefRangeStart = 103594, XrefRangeEnd = 103598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000CA534 File Offset: 0x000C8734
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 103877, RefRangeEnd = 104078, XrefRangeStart = 103873, XrefRangeEnd = 103877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000CA57C File Offset: 0x000C877C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104116, RefRangeEnd = 104117, XrefRangeStart = 104078, XrefRangeEnd = 104116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SubmitCommand(List<string> args)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000CA5B4 File Offset: 0x000C87B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104133, RefRangeEnd = 104136, XrefRangeStart = 104117, XrefRangeEnd = 104133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SubmitCommand(string args)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000CA5EC File Offset: 0x000C87EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104136, XrefRangeEnd = 104158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinding(KeyCode key, string command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(command);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000CA63C File Offset: 0x000C883C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104158, XrefRangeEnd = 104174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBinding(KeyCode key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000CA67C File Offset: 0x000C887C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104174, XrefRangeEnd = 104187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ClearBindings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000CA6B0 File Offset: 0x000C88B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104187, XrefRangeEnd = 104216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000CA6E4 File Offset: 0x000C88E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104216, XrefRangeEnd = 104233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Console() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000107D3 File Offset: 0x0000E9D3
		public Console(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x000CA720 File Offset: 0x000C8920
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x000107DC File Offset: 0x0000E9DC
		public unsafe Transform TeleportPointsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_TeleportPointsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_TeleportPointsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x000CA750 File Offset: 0x000C8950
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x000107FB File Offset: 0x0000E9FB
		public unsafe List<Console.LabelledGameObject> LabelledGameObjectList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_LabelledGameObjectList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Console.LabelledGameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_LabelledGameObjectList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x000CA780 File Offset: 0x000C8980
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0001081A File Offset: 0x0000EA1A
		public unsafe List<string> startupCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_startupCommands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_startupCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x000CA7B0 File Offset: 0x000C89B0
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x00010839 File Offset: 0x0000EA39
		public unsafe static List<Console.ConsoleCommand> Commands
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_Commands, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Console.ConsoleCommand>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_Commands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x000CA7D8 File Offset: 0x000C89D8
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x0001084B File Offset: 0x0000EA4B
		public unsafe static Dictionary<string, Console.ConsoleCommand> commands
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_commands, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Console.ConsoleCommand>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_commands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000CA800 File Offset: 0x000C8A00
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0001085D File Offset: 0x0000EA5D
		public unsafe Dictionary<KeyCode, string> keyBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_keyBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<KeyCode, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_keyBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeFieldInfoPtr_TeleportPointsContainer;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeFieldInfoPtr_LabelledGameObjectList;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeFieldInfoPtr_startupCommands;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeFieldInfoPtr_Commands;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeFieldInfoPtr_commands;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeFieldInfoPtr_keyBindings;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_Static_get_Player_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_RunStartupCommands_Private_Void_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_ClearBindings_Public_Void_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200086F RID: 2159
		public class ConsoleCommand : Il2CppSystem.Object
		{
			// Token: 0x0600C156 RID: 49494 RVA: 0x002F2FF8 File Offset: 0x002F11F8
			// Note: this type is marked as 'beforefieldinit'.
			static ConsoleCommand()
			{
				Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ConsoleCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666338);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666339);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666340);
				Console.ConsoleCommand.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666341);
				Console.ConsoleCommand.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100666342);
			}

			// Token: 0x17003C3F RID: 15423
			// (get) Token: 0x0600C157 RID: 49495 RVA: 0x002F3088 File Offset: 0x002F1288
			public unsafe virtual string CommandWord
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C40 RID: 15424
			// (get) Token: 0x0600C158 RID: 49496 RVA: 0x002F30CC File Offset: 0x002F12CC
			public unsafe virtual string CommandDescription
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C41 RID: 15425
			// (get) Token: 0x0600C159 RID: 49497 RVA: 0x002F3110 File Offset: 0x002F1310
			public unsafe virtual string ExampleUsage
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C15A RID: 49498 RVA: 0x002F3154 File Offset: 0x002F1354
			[CallerCount(0)]
			public unsafe virtual void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C15B RID: 49499 RVA: 0x002F31A4 File Offset: 0x002F13A4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConsoleCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ConsoleCommand.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C15C RID: 49500 RVA: 0x0005E8F9 File Offset: 0x0005CAF9
			public ConsoleCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040082E6 RID: 33510
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x040082E7 RID: 33511
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x040082E8 RID: 33512
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x040082E9 RID: 33513
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0;

			// Token: 0x040082EA RID: 33514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x02000870 RID: 2160
		public class SetTimeCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C15D RID: 49501 RVA: 0x002F31E0 File Offset: 0x002F13E0
			// Note: this type is marked as 'beforefieldinit'.
			static SetTimeCommand()
			{
				Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetTimeCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666343);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666344);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666345);
				Console.SetTimeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666346);
				Console.SetTimeCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100666347);
			}

			// Token: 0x17003C42 RID: 15426
			// (get) Token: 0x0600C15E RID: 49502 RVA: 0x002F3270 File Offset: 0x002F1470
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101411, XrefRangeEnd = 101413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C43 RID: 15427
			// (get) Token: 0x0600C15F RID: 49503 RVA: 0x002F32B4 File Offset: 0x002F14B4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101413, XrefRangeEnd = 101415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C44 RID: 15428
			// (get) Token: 0x0600C160 RID: 49504 RVA: 0x002F32F8 File Offset: 0x002F14F8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101415, XrefRangeEnd = 101417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C161 RID: 49505 RVA: 0x002F333C File Offset: 0x002F153C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101417, XrefRangeEnd = 101457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C162 RID: 49506 RVA: 0x002F338C File Offset: 0x002F158C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetTimeCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetTimeCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C163 RID: 49507 RVA: 0x0005E902 File Offset: 0x0005CB02
			public SetTimeCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040082EB RID: 33515
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040082EC RID: 33516
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040082ED RID: 33517
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040082EE RID: 33518
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040082EF RID: 33519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000871 RID: 2161
		public class SpawnVehicleCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C164 RID: 49508 RVA: 0x002F33C8 File Offset: 0x002F15C8
			// Note: this type is marked as 'beforefieldinit'.
			static SpawnVehicleCommand()
			{
				Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SpawnVehicleCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666348);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666349);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666350);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666351);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100666352);
			}

			// Token: 0x17003C45 RID: 15429
			// (get) Token: 0x0600C165 RID: 49509 RVA: 0x002F3458 File Offset: 0x002F1658
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101457, XrefRangeEnd = 101459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C46 RID: 15430
			// (get) Token: 0x0600C166 RID: 49510 RVA: 0x002F349C File Offset: 0x002F169C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101459, XrefRangeEnd = 101461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C47 RID: 15431
			// (get) Token: 0x0600C167 RID: 49511 RVA: 0x002F34E0 File Offset: 0x002F16E0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101461, XrefRangeEnd = 101463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C168 RID: 49512 RVA: 0x002F3524 File Offset: 0x002F1724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101463, XrefRangeEnd = 101520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C169 RID: 49513 RVA: 0x002F3574 File Offset: 0x002F1774
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpawnVehicleCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SpawnVehicleCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C16A RID: 49514 RVA: 0x0005E90B File Offset: 0x0005CB0B
			public SpawnVehicleCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040082F0 RID: 33520
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040082F1 RID: 33521
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040082F2 RID: 33522
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040082F3 RID: 33523
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040082F4 RID: 33524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000872 RID: 2162
		public class AddItemToInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C16B RID: 49515 RVA: 0x002F35B0 File Offset: 0x002F17B0
			// Note: this type is marked as 'beforefieldinit'.
			static AddItemToInventoryCommand()
			{
				Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "AddItemToInventoryCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666353);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666354);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666355);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666356);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100666357);
			}

			// Token: 0x17003C48 RID: 15432
			// (get) Token: 0x0600C16C RID: 49516 RVA: 0x002F3640 File Offset: 0x002F1840
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101520, XrefRangeEnd = 101522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C49 RID: 15433
			// (get) Token: 0x0600C16D RID: 49517 RVA: 0x002F3684 File Offset: 0x002F1884
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101522, XrefRangeEnd = 101524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C4A RID: 15434
			// (get) Token: 0x0600C16E RID: 49518 RVA: 0x002F36C8 File Offset: 0x002F18C8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101524, XrefRangeEnd = 101526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C16F RID: 49519 RVA: 0x002F370C File Offset: 0x002F190C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101526, XrefRangeEnd = 101563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C170 RID: 49520 RVA: 0x002F375C File Offset: 0x002F195C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddItemToInventoryCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddItemToInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C171 RID: 49521 RVA: 0x0005E914 File Offset: 0x0005CB14
			public AddItemToInventoryCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040082F5 RID: 33525
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040082F6 RID: 33526
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040082F7 RID: 33527
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040082F8 RID: 33528
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040082F9 RID: 33529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000873 RID: 2163
		public class ClearInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C172 RID: 49522 RVA: 0x002F3798 File Offset: 0x002F1998
			// Note: this type is marked as 'beforefieldinit'.
			static ClearInventoryCommand()
			{
				Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearInventoryCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666358);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666359);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666360);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666361);
				Console.ClearInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100666362);
			}

			// Token: 0x17003C4B RID: 15435
			// (get) Token: 0x0600C173 RID: 49523 RVA: 0x002F3828 File Offset: 0x002F1A28
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101563, XrefRangeEnd = 101565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C4C RID: 15436
			// (get) Token: 0x0600C174 RID: 49524 RVA: 0x002F386C File Offset: 0x002F1A6C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101565, XrefRangeEnd = 101567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C4D RID: 15437
			// (get) Token: 0x0600C175 RID: 49525 RVA: 0x002F38B0 File Offset: 0x002F1AB0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101567, XrefRangeEnd = 101569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C176 RID: 49526 RVA: 0x002F38F4 File Offset: 0x002F1AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101569, XrefRangeEnd = 101584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C177 RID: 49527 RVA: 0x002F3944 File Offset: 0x002F1B44
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearInventoryCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C178 RID: 49528 RVA: 0x0005E91D File Offset: 0x0005CB1D
			public ClearInventoryCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040082FA RID: 33530
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040082FB RID: 33531
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040082FC RID: 33532
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040082FD RID: 33533
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040082FE RID: 33534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000874 RID: 2164
		public class ChangeCashCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C179 RID: 49529 RVA: 0x002F3980 File Offset: 0x002F1B80
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeCashCommand()
			{
				Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ChangeCashCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666363);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666364);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666365);
				Console.ChangeCashCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666366);
				Console.ChangeCashCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100666367);
			}

			// Token: 0x17003C4E RID: 15438
			// (get) Token: 0x0600C17A RID: 49530 RVA: 0x002F3A10 File Offset: 0x002F1C10
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101584, XrefRangeEnd = 101586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C4F RID: 15439
			// (get) Token: 0x0600C17B RID: 49531 RVA: 0x002F3A54 File Offset: 0x002F1C54
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101586, XrefRangeEnd = 101588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C50 RID: 15440
			// (get) Token: 0x0600C17C RID: 49532 RVA: 0x002F3A98 File Offset: 0x002F1C98
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101588, XrefRangeEnd = 101590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C17D RID: 49533 RVA: 0x002F3ADC File Offset: 0x002F1CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101590, XrefRangeEnd = 101616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C17E RID: 49534 RVA: 0x002F3B2C File Offset: 0x002F1D2C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeCashCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ChangeCashCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C17F RID: 49535 RVA: 0x0005E926 File Offset: 0x0005CB26
			public ChangeCashCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040082FF RID: 33535
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008300 RID: 33536
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008301 RID: 33537
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008302 RID: 33538
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008303 RID: 33539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000875 RID: 2165
		public class ChangeOnlineBalanceCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C180 RID: 49536 RVA: 0x002F3B68 File Offset: 0x002F1D68
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeOnlineBalanceCommand()
			{
				Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ChangeOnlineBalanceCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666368);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666369);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666370);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666371);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100666372);
			}

			// Token: 0x17003C51 RID: 15441
			// (get) Token: 0x0600C181 RID: 49537 RVA: 0x002F3BF8 File Offset: 0x002F1DF8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101616, XrefRangeEnd = 101618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C52 RID: 15442
			// (get) Token: 0x0600C182 RID: 49538 RVA: 0x002F3C3C File Offset: 0x002F1E3C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101618, XrefRangeEnd = 101620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C53 RID: 15443
			// (get) Token: 0x0600C183 RID: 49539 RVA: 0x002F3C80 File Offset: 0x002F1E80
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101620, XrefRangeEnd = 101622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C184 RID: 49540 RVA: 0x002F3CC4 File Offset: 0x002F1EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101622, XrefRangeEnd = 101650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C185 RID: 49541 RVA: 0x002F3D14 File Offset: 0x002F1F14
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeOnlineBalanceCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C186 RID: 49542 RVA: 0x0005E92F File Offset: 0x0005CB2F
			public ChangeOnlineBalanceCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008304 RID: 33540
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008305 RID: 33541
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008306 RID: 33542
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008307 RID: 33543
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008308 RID: 33544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000876 RID: 2166
		public class SetMoveSpeedCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C187 RID: 49543 RVA: 0x002F3D50 File Offset: 0x002F1F50
			// Note: this type is marked as 'beforefieldinit'.
			static SetMoveSpeedCommand()
			{
				Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetMoveSpeedCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666373);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666374);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666375);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666376);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100666377);
			}

			// Token: 0x17003C54 RID: 15444
			// (get) Token: 0x0600C188 RID: 49544 RVA: 0x002F3DE0 File Offset: 0x002F1FE0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101650, XrefRangeEnd = 101652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C55 RID: 15445
			// (get) Token: 0x0600C189 RID: 49545 RVA: 0x002F3E24 File Offset: 0x002F2024
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101652, XrefRangeEnd = 101654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C56 RID: 15446
			// (get) Token: 0x0600C18A RID: 49546 RVA: 0x002F3E68 File Offset: 0x002F2068
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101654, XrefRangeEnd = 101656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C18B RID: 49547 RVA: 0x002F3EAC File Offset: 0x002F20AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101656, XrefRangeEnd = 101674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C18C RID: 49548 RVA: 0x002F3EFC File Offset: 0x002F20FC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetMoveSpeedCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetMoveSpeedCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C18D RID: 49549 RVA: 0x0005E938 File Offset: 0x0005CB38
			public SetMoveSpeedCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008309 RID: 33545
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400830A RID: 33546
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400830B RID: 33547
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400830C RID: 33548
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400830D RID: 33549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000877 RID: 2167
		public class SetJumpMultiplier : Console.ConsoleCommand
		{
			// Token: 0x0600C18E RID: 49550 RVA: 0x002F3F38 File Offset: 0x002F2138
			// Note: this type is marked as 'beforefieldinit'.
			static SetJumpMultiplier()
			{
				Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetJumpMultiplier");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666378);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666379);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666380);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666381);
				Console.SetJumpMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100666382);
			}

			// Token: 0x17003C57 RID: 15447
			// (get) Token: 0x0600C18F RID: 49551 RVA: 0x002F3FC8 File Offset: 0x002F21C8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101674, XrefRangeEnd = 101676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C58 RID: 15448
			// (get) Token: 0x0600C190 RID: 49552 RVA: 0x002F400C File Offset: 0x002F220C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101676, XrefRangeEnd = 101678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C59 RID: 15449
			// (get) Token: 0x0600C191 RID: 49553 RVA: 0x002F4050 File Offset: 0x002F2250
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101678, XrefRangeEnd = 101680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C192 RID: 49554 RVA: 0x002F4094 File Offset: 0x002F2294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101680, XrefRangeEnd = 101698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C193 RID: 49555 RVA: 0x002F40E4 File Offset: 0x002F22E4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetJumpMultiplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetJumpMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C194 RID: 49556 RVA: 0x0005E941 File Offset: 0x0005CB41
			public SetJumpMultiplier(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400830E RID: 33550
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400830F RID: 33551
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008310 RID: 33552
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008311 RID: 33553
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008312 RID: 33554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000878 RID: 2168
		public class SetPropertyOwned : Console.ConsoleCommand
		{
			// Token: 0x0600C195 RID: 49557 RVA: 0x002F4120 File Offset: 0x002F2320
			// Note: this type is marked as 'beforefieldinit'.
			static SetPropertyOwned()
			{
				Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetPropertyOwned");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666383);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666384);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666385);
				Console.SetPropertyOwned.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666386);
				Console.SetPropertyOwned.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100666387);
			}

			// Token: 0x17003C5A RID: 15450
			// (get) Token: 0x0600C196 RID: 49558 RVA: 0x002F41B0 File Offset: 0x002F23B0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101701, XrefRangeEnd = 101703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C5B RID: 15451
			// (get) Token: 0x0600C197 RID: 49559 RVA: 0x002F41F4 File Offset: 0x002F23F4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101703, XrefRangeEnd = 101705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C5C RID: 15452
			// (get) Token: 0x0600C198 RID: 49560 RVA: 0x002F4238 File Offset: 0x002F2438
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101705, XrefRangeEnd = 101707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C199 RID: 49561 RVA: 0x002F427C File Offset: 0x002F247C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101707, XrefRangeEnd = 101736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C19A RID: 49562 RVA: 0x002F42CC File Offset: 0x002F24CC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetPropertyOwned() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C19B RID: 49563 RVA: 0x0005E94A File Offset: 0x0005CB4A
			public SetPropertyOwned(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008313 RID: 33555
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008314 RID: 33556
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008315 RID: 33557
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008316 RID: 33558
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008317 RID: 33559
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C2C RID: 3116
			[ObfuscatedName("ScheduleOne.Console+SetPropertyOwned+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E114 RID: 57620 RVA: 0x0034EA34 File Offset: 0x0034CC34
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100666388);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100666389);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100666390);
				}

				// Token: 0x0600E115 RID: 57621 RVA: 0x0034EAB0 File Offset: 0x0034CCB0
				[CallerCount(2259)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E116 RID: 57622 RVA: 0x0034EAEC File Offset: 0x0034CCEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101698, XrefRangeEnd = 101701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Property x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E117 RID: 57623 RVA: 0x0034EB3C File Offset: 0x0034CD3C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__1(Business x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E118 RID: 57624 RVA: 0x0006DBFD File Offset: 0x0006BDFD
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045BD RID: 17853
				// (get) Token: 0x0600E119 RID: 57625 RVA: 0x0034EB8C File Offset: 0x0034CD8C
				// (set) Token: 0x0600E11A RID: 57626 RVA: 0x0006DC06 File Offset: 0x0006BE06
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x040096B9 RID: 38585
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x040096BA RID: 38586
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040096BB RID: 38587
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0;

				// Token: 0x040096BC RID: 38588
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0;
			}
		}

		// Token: 0x02000879 RID: 2169
		public class Teleport : Console.ConsoleCommand
		{
			// Token: 0x0600C19C RID: 49564 RVA: 0x002F4308 File Offset: 0x002F2508
			// Note: this type is marked as 'beforefieldinit'.
			static Teleport()
			{
				Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Teleport");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr);
				Console.Teleport.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666391);
				Console.Teleport.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666392);
				Console.Teleport.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666393);
				Console.Teleport.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666394);
				Console.Teleport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100666395);
			}

			// Token: 0x17003C5D RID: 15453
			// (get) Token: 0x0600C19D RID: 49565 RVA: 0x002F4398 File Offset: 0x002F2598
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101736, XrefRangeEnd = 101738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C5E RID: 15454
			// (get) Token: 0x0600C19E RID: 49566 RVA: 0x002F43DC File Offset: 0x002F25DC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101738, XrefRangeEnd = 101740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C5F RID: 15455
			// (get) Token: 0x0600C19F RID: 49567 RVA: 0x002F4420 File Offset: 0x002F2620
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101740, XrefRangeEnd = 101742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1A0 RID: 49568 RVA: 0x002F4464 File Offset: 0x002F2664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101742, XrefRangeEnd = 101770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1A1 RID: 49569 RVA: 0x002F44B4 File Offset: 0x002F26B4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Teleport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Teleport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1A2 RID: 49570 RVA: 0x0005E953 File Offset: 0x0005CB53
			public Teleport(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008318 RID: 33560
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008319 RID: 33561
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400831A RID: 33562
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400831B RID: 33563
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400831C RID: 33564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087A RID: 2170
		public class PackageProduct : Console.ConsoleCommand
		{
			// Token: 0x0600C1A3 RID: 49571 RVA: 0x002F44F0 File Offset: 0x002F26F0
			// Note: this type is marked as 'beforefieldinit'.
			static PackageProduct()
			{
				Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "PackageProduct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr);
				Console.PackageProduct.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666396);
				Console.PackageProduct.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666397);
				Console.PackageProduct.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666398);
				Console.PackageProduct.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666399);
				Console.PackageProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100666400);
			}

			// Token: 0x17003C60 RID: 15456
			// (get) Token: 0x0600C1A4 RID: 49572 RVA: 0x002F4580 File Offset: 0x002F2780
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101770, XrefRangeEnd = 101772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C61 RID: 15457
			// (get) Token: 0x0600C1A5 RID: 49573 RVA: 0x002F45C4 File Offset: 0x002F27C4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101772, XrefRangeEnd = 101774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C62 RID: 15458
			// (get) Token: 0x0600C1A6 RID: 49574 RVA: 0x002F4608 File Offset: 0x002F2808
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101774, XrefRangeEnd = 101776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1A7 RID: 49575 RVA: 0x002F464C File Offset: 0x002F284C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101776, XrefRangeEnd = 101842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1A8 RID: 49576 RVA: 0x002F469C File Offset: 0x002F289C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackageProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.PackageProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1A9 RID: 49577 RVA: 0x0005E95C File Offset: 0x0005CB5C
			public PackageProduct(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400831D RID: 33565
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400831E RID: 33566
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400831F RID: 33567
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008320 RID: 33568
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008321 RID: 33569
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087B RID: 2171
		public class SetStaminaReserve : Console.ConsoleCommand
		{
			// Token: 0x0600C1AA RID: 49578 RVA: 0x002F46D8 File Offset: 0x002F28D8
			// Note: this type is marked as 'beforefieldinit'.
			static SetStaminaReserve()
			{
				Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetStaminaReserve");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666401);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666402);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666403);
				Console.SetStaminaReserve.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666404);
				Console.SetStaminaReserve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100666405);
			}

			// Token: 0x17003C63 RID: 15459
			// (get) Token: 0x0600C1AB RID: 49579 RVA: 0x002F4768 File Offset: 0x002F2968
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101842, XrefRangeEnd = 101844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C64 RID: 15460
			// (get) Token: 0x0600C1AC RID: 49580 RVA: 0x002F47AC File Offset: 0x002F29AC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101844, XrefRangeEnd = 101846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C65 RID: 15461
			// (get) Token: 0x0600C1AD RID: 49581 RVA: 0x002F47F0 File Offset: 0x002F29F0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101846, XrefRangeEnd = 101848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1AE RID: 49582 RVA: 0x002F4834 File Offset: 0x002F2A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101848, XrefRangeEnd = 101870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1AF RID: 49583 RVA: 0x002F4884 File Offset: 0x002F2A84
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetStaminaReserve() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetStaminaReserve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1B0 RID: 49584 RVA: 0x0005E965 File Offset: 0x0005CB65
			public SetStaminaReserve(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008322 RID: 33570
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008323 RID: 33571
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008324 RID: 33572
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008325 RID: 33573
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008326 RID: 33574
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087C RID: 2172
		public class RaisedWanted : Console.ConsoleCommand
		{
			// Token: 0x0600C1B1 RID: 49585 RVA: 0x002F48C0 File Offset: 0x002F2AC0
			// Note: this type is marked as 'beforefieldinit'.
			static RaisedWanted()
			{
				Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "RaisedWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr);
				Console.RaisedWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666406);
				Console.RaisedWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666407);
				Console.RaisedWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666408);
				Console.RaisedWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666409);
				Console.RaisedWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100666410);
			}

			// Token: 0x17003C66 RID: 15462
			// (get) Token: 0x0600C1B2 RID: 49586 RVA: 0x002F4950 File Offset: 0x002F2B50
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101870, XrefRangeEnd = 101872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C67 RID: 15463
			// (get) Token: 0x0600C1B3 RID: 49587 RVA: 0x002F4994 File Offset: 0x002F2B94
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101872, XrefRangeEnd = 101874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C68 RID: 15464
			// (get) Token: 0x0600C1B4 RID: 49588 RVA: 0x002F49D8 File Offset: 0x002F2BD8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101874, XrefRangeEnd = 101876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1B5 RID: 49589 RVA: 0x002F4A1C File Offset: 0x002F2C1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101876, XrefRangeEnd = 101913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1B6 RID: 49590 RVA: 0x002F4A6C File Offset: 0x002F2C6C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaisedWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.RaisedWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1B7 RID: 49591 RVA: 0x0005E96E File Offset: 0x0005CB6E
			public RaisedWanted(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008327 RID: 33575
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008328 RID: 33576
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008329 RID: 33577
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400832A RID: 33578
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400832B RID: 33579
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087D RID: 2173
		public class LowerWanted : Console.ConsoleCommand
		{
			// Token: 0x0600C1B8 RID: 49592 RVA: 0x002F4AA8 File Offset: 0x002F2CA8
			// Note: this type is marked as 'beforefieldinit'.
			static LowerWanted()
			{
				Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "LowerWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr);
				Console.LowerWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666411);
				Console.LowerWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666412);
				Console.LowerWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666413);
				Console.LowerWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666414);
				Console.LowerWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100666415);
			}

			// Token: 0x17003C69 RID: 15465
			// (get) Token: 0x0600C1B9 RID: 49593 RVA: 0x002F4B38 File Offset: 0x002F2D38
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101913, XrefRangeEnd = 101915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C6A RID: 15466
			// (get) Token: 0x0600C1BA RID: 49594 RVA: 0x002F4B7C File Offset: 0x002F2D7C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101915, XrefRangeEnd = 101917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C6B RID: 15467
			// (get) Token: 0x0600C1BB RID: 49595 RVA: 0x002F4BC0 File Offset: 0x002F2DC0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101917, XrefRangeEnd = 101919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1BC RID: 49596 RVA: 0x002F4C04 File Offset: 0x002F2E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101919, XrefRangeEnd = 101934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1BD RID: 49597 RVA: 0x002F4C54 File Offset: 0x002F2E54
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowerWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.LowerWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1BE RID: 49598 RVA: 0x0005E977 File Offset: 0x0005CB77
			public LowerWanted(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400832C RID: 33580
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400832D RID: 33581
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400832E RID: 33582
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400832F RID: 33583
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008330 RID: 33584
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087E RID: 2174
		public class ClearWanted : Console.ConsoleCommand
		{
			// Token: 0x0600C1BF RID: 49599 RVA: 0x002F4C90 File Offset: 0x002F2E90
			// Note: this type is marked as 'beforefieldinit'.
			static ClearWanted()
			{
				Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr);
				Console.ClearWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666416);
				Console.ClearWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666417);
				Console.ClearWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666418);
				Console.ClearWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666419);
				Console.ClearWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100666420);
			}

			// Token: 0x17003C6C RID: 15468
			// (get) Token: 0x0600C1C0 RID: 49600 RVA: 0x002F4D20 File Offset: 0x002F2F20
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101934, XrefRangeEnd = 101936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C6D RID: 15469
			// (get) Token: 0x0600C1C1 RID: 49601 RVA: 0x002F4D64 File Offset: 0x002F2F64
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101936, XrefRangeEnd = 101938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C6E RID: 15470
			// (get) Token: 0x0600C1C2 RID: 49602 RVA: 0x002F4DA8 File Offset: 0x002F2FA8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101938, XrefRangeEnd = 101940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1C3 RID: 49603 RVA: 0x002F4DEC File Offset: 0x002F2FEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101940, XrefRangeEnd = 101960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1C4 RID: 49604 RVA: 0x002F4E3C File Offset: 0x002F303C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1C5 RID: 49605 RVA: 0x0005E980 File Offset: 0x0005CB80
			public ClearWanted(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008331 RID: 33585
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008332 RID: 33586
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008333 RID: 33587
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008334 RID: 33588
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008335 RID: 33589
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200087F RID: 2175
		public class SetHealth : Console.ConsoleCommand
		{
			// Token: 0x0600C1C6 RID: 49606 RVA: 0x002F4E78 File Offset: 0x002F3078
			// Note: this type is marked as 'beforefieldinit'.
			static SetHealth()
			{
				Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetHealth");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr);
				Console.SetHealth.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666421);
				Console.SetHealth.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666422);
				Console.SetHealth.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666423);
				Console.SetHealth.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666424);
				Console.SetHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100666425);
			}

			// Token: 0x17003C6F RID: 15471
			// (get) Token: 0x0600C1C7 RID: 49607 RVA: 0x002F4F08 File Offset: 0x002F3108
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101960, XrefRangeEnd = 101962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C70 RID: 15472
			// (get) Token: 0x0600C1C8 RID: 49608 RVA: 0x002F4F4C File Offset: 0x002F314C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101962, XrefRangeEnd = 101964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C71 RID: 15473
			// (get) Token: 0x0600C1C9 RID: 49609 RVA: 0x002F4F90 File Offset: 0x002F3190
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101964, XrefRangeEnd = 101966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1CA RID: 49610 RVA: 0x002F4FD4 File Offset: 0x002F31D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101966, XrefRangeEnd = 101993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1CB RID: 49611 RVA: 0x002F5024 File Offset: 0x002F3224
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1CC RID: 49612 RVA: 0x0005E989 File Offset: 0x0005CB89
			public SetHealth(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008336 RID: 33590
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008337 RID: 33591
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008338 RID: 33592
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008339 RID: 33593
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400833A RID: 33594
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000880 RID: 2176
		public class SetEnergy : Console.ConsoleCommand
		{
			// Token: 0x0600C1CD RID: 49613 RVA: 0x002F5060 File Offset: 0x002F3260
			// Note: this type is marked as 'beforefieldinit'.
			static SetEnergy()
			{
				Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetEnergy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr);
				Console.SetEnergy.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666426);
				Console.SetEnergy.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666427);
				Console.SetEnergy.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666428);
				Console.SetEnergy.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666429);
				Console.SetEnergy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr, 100666430);
			}

			// Token: 0x17003C72 RID: 15474
			// (get) Token: 0x0600C1CE RID: 49614 RVA: 0x002F50F0 File Offset: 0x002F32F0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101993, XrefRangeEnd = 101995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C73 RID: 15475
			// (get) Token: 0x0600C1CF RID: 49615 RVA: 0x002F5134 File Offset: 0x002F3334
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101995, XrefRangeEnd = 101997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C74 RID: 15476
			// (get) Token: 0x0600C1D0 RID: 49616 RVA: 0x002F5178 File Offset: 0x002F3378
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101997, XrefRangeEnd = 101999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1D1 RID: 49617 RVA: 0x002F51BC File Offset: 0x002F33BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101999, XrefRangeEnd = 102018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEnergy.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1D2 RID: 49618 RVA: 0x002F520C File Offset: 0x002F340C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetEnergy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetEnergy>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetEnergy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1D3 RID: 49619 RVA: 0x0005E992 File Offset: 0x0005CB92
			public SetEnergy(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400833B RID: 33595
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400833C RID: 33596
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400833D RID: 33597
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400833E RID: 33598
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400833F RID: 33599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000881 RID: 2177
		public class FreeCamCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C1D4 RID: 49620 RVA: 0x002F5248 File Offset: 0x002F3448
			// Note: this type is marked as 'beforefieldinit'.
			static FreeCamCommand()
			{
				Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "FreeCamCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666431);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666432);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666433);
				Console.FreeCamCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666434);
				Console.FreeCamCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100666435);
			}

			// Token: 0x17003C75 RID: 15477
			// (get) Token: 0x0600C1D5 RID: 49621 RVA: 0x002F52D8 File Offset: 0x002F34D8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102018, XrefRangeEnd = 102020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C76 RID: 15478
			// (get) Token: 0x0600C1D6 RID: 49622 RVA: 0x002F531C File Offset: 0x002F351C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102020, XrefRangeEnd = 102022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C77 RID: 15479
			// (get) Token: 0x0600C1D7 RID: 49623 RVA: 0x002F5360 File Offset: 0x002F3560
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102022, XrefRangeEnd = 102024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1D8 RID: 49624 RVA: 0x002F53A4 File Offset: 0x002F35A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102024, XrefRangeEnd = 102037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1D9 RID: 49625 RVA: 0x002F53F4 File Offset: 0x002F35F4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FreeCamCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.FreeCamCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1DA RID: 49626 RVA: 0x0005E99B File Offset: 0x0005CB9B
			public FreeCamCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008340 RID: 33600
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008341 RID: 33601
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008342 RID: 33602
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008343 RID: 33603
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008344 RID: 33604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000882 RID: 2178
		public class Save : Console.ConsoleCommand
		{
			// Token: 0x0600C1DB RID: 49627 RVA: 0x002F5430 File Offset: 0x002F3630
			// Note: this type is marked as 'beforefieldinit'.
			static Save()
			{
				Il2CppClassPointerStore<Console.Save>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Save");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Save>.NativeClassPtr);
				Console.Save.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666436);
				Console.Save.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666437);
				Console.Save.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666438);
				Console.Save.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666439);
				Console.Save.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100666440);
			}

			// Token: 0x17003C78 RID: 15480
			// (get) Token: 0x0600C1DC RID: 49628 RVA: 0x002F54C0 File Offset: 0x002F36C0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102037, XrefRangeEnd = 102039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C79 RID: 15481
			// (get) Token: 0x0600C1DD RID: 49629 RVA: 0x002F5504 File Offset: 0x002F3704
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102039, XrefRangeEnd = 102041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C7A RID: 15482
			// (get) Token: 0x0600C1DE RID: 49630 RVA: 0x002F5548 File Offset: 0x002F3748
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102041, XrefRangeEnd = 102043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1DF RID: 49631 RVA: 0x002F558C File Offset: 0x002F378C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102043, XrefRangeEnd = 102058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1E0 RID: 49632 RVA: 0x002F55DC File Offset: 0x002F37DC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Save() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Save>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Save.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1E1 RID: 49633 RVA: 0x0005E9A4 File Offset: 0x0005CBA4
			public Save(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008345 RID: 33605
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008346 RID: 33606
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008347 RID: 33607
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008348 RID: 33608
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008349 RID: 33609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000883 RID: 2179
		public class SetTimeScale : Console.ConsoleCommand
		{
			// Token: 0x0600C1E2 RID: 49634 RVA: 0x002F5618 File Offset: 0x002F3818
			// Note: this type is marked as 'beforefieldinit'.
			static SetTimeScale()
			{
				Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetTimeScale");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr);
				Console.SetTimeScale.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666441);
				Console.SetTimeScale.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666442);
				Console.SetTimeScale.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666443);
				Console.SetTimeScale.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666444);
				Console.SetTimeScale.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100666445);
			}

			// Token: 0x17003C7B RID: 15483
			// (get) Token: 0x0600C1E3 RID: 49635 RVA: 0x002F56A8 File Offset: 0x002F38A8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102058, XrefRangeEnd = 102060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C7C RID: 15484
			// (get) Token: 0x0600C1E4 RID: 49636 RVA: 0x002F56EC File Offset: 0x002F38EC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102060, XrefRangeEnd = 102062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C7D RID: 15485
			// (get) Token: 0x0600C1E5 RID: 49637 RVA: 0x002F5730 File Offset: 0x002F3930
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102062, XrefRangeEnd = 102064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1E6 RID: 49638 RVA: 0x002F5774 File Offset: 0x002F3974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102064, XrefRangeEnd = 102085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1E7 RID: 49639 RVA: 0x002F57C4 File Offset: 0x002F39C4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetTimeScale() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetTimeScale.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1E8 RID: 49640 RVA: 0x0005E9AD File Offset: 0x0005CBAD
			public SetTimeScale(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400834A RID: 33610
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400834B RID: 33611
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400834C RID: 33612
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400834D RID: 33613
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400834E RID: 33614
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000884 RID: 2180
		public class SetVariableValue : Console.ConsoleCommand
		{
			// Token: 0x0600C1E9 RID: 49641 RVA: 0x002F5800 File Offset: 0x002F3A00
			// Note: this type is marked as 'beforefieldinit'.
			static SetVariableValue()
			{
				Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetVariableValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr);
				Console.SetVariableValue.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666446);
				Console.SetVariableValue.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666447);
				Console.SetVariableValue.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666448);
				Console.SetVariableValue.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666449);
				Console.SetVariableValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100666450);
			}

			// Token: 0x17003C7E RID: 15486
			// (get) Token: 0x0600C1EA RID: 49642 RVA: 0x002F5890 File Offset: 0x002F3A90
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102085, XrefRangeEnd = 102087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C7F RID: 15487
			// (get) Token: 0x0600C1EB RID: 49643 RVA: 0x002F58D4 File Offset: 0x002F3AD4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102087, XrefRangeEnd = 102089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C80 RID: 15488
			// (get) Token: 0x0600C1EC RID: 49644 RVA: 0x002F5918 File Offset: 0x002F3B18
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102089, XrefRangeEnd = 102091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1ED RID: 49645 RVA: 0x002F595C File Offset: 0x002F3B5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102091, XrefRangeEnd = 102113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1EE RID: 49646 RVA: 0x002F59AC File Offset: 0x002F3BAC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetVariableValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetVariableValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1EF RID: 49647 RVA: 0x0005E9B6 File Offset: 0x0005CBB6
			public SetVariableValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400834F RID: 33615
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008350 RID: 33616
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008351 RID: 33617
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008352 RID: 33618
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008353 RID: 33619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000885 RID: 2181
		public class SetQuestState : Console.ConsoleCommand
		{
			// Token: 0x0600C1F0 RID: 49648 RVA: 0x002F59E8 File Offset: 0x002F3BE8
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuestState()
			{
				Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuestState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr);
				Console.SetQuestState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666451);
				Console.SetQuestState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666452);
				Console.SetQuestState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666453);
				Console.SetQuestState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666454);
				Console.SetQuestState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100666455);
			}

			// Token: 0x17003C81 RID: 15489
			// (get) Token: 0x0600C1F1 RID: 49649 RVA: 0x002F5A78 File Offset: 0x002F3C78
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102113, XrefRangeEnd = 102115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C82 RID: 15490
			// (get) Token: 0x0600C1F2 RID: 49650 RVA: 0x002F5ABC File Offset: 0x002F3CBC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102115, XrefRangeEnd = 102117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C83 RID: 15491
			// (get) Token: 0x0600C1F3 RID: 49651 RVA: 0x002F5B00 File Offset: 0x002F3D00
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102117, XrefRangeEnd = 102119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1F4 RID: 49652 RVA: 0x002F5B44 File Offset: 0x002F3D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102119, XrefRangeEnd = 102153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1F5 RID: 49653 RVA: 0x002F5B94 File Offset: 0x002F3D94
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuestState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuestState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1F6 RID: 49654 RVA: 0x0005E9BF File Offset: 0x0005CBBF
			public SetQuestState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008354 RID: 33620
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008355 RID: 33621
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008356 RID: 33622
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008357 RID: 33623
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008358 RID: 33624
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000886 RID: 2182
		public class SetQuestEntryState : Console.ConsoleCommand
		{
			// Token: 0x0600C1F7 RID: 49655 RVA: 0x002F5BD0 File Offset: 0x002F3DD0
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuestEntryState()
			{
				Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuestEntryState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666456);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666457);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666458);
				Console.SetQuestEntryState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666459);
				Console.SetQuestEntryState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100666460);
			}

			// Token: 0x17003C84 RID: 15492
			// (get) Token: 0x0600C1F8 RID: 49656 RVA: 0x002F5C60 File Offset: 0x002F3E60
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102153, XrefRangeEnd = 102155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C85 RID: 15493
			// (get) Token: 0x0600C1F9 RID: 49657 RVA: 0x002F5CA4 File Offset: 0x002F3EA4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102155, XrefRangeEnd = 102157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C86 RID: 15494
			// (get) Token: 0x0600C1FA RID: 49658 RVA: 0x002F5CE8 File Offset: 0x002F3EE8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102157, XrefRangeEnd = 102159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C1FB RID: 49659 RVA: 0x002F5D2C File Offset: 0x002F3F2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102159, XrefRangeEnd = 102198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1FC RID: 49660 RVA: 0x002F5D7C File Offset: 0x002F3F7C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuestEntryState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuestEntryState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1FD RID: 49661 RVA: 0x0005E9C8 File Offset: 0x0005CBC8
			public SetQuestEntryState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008359 RID: 33625
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400835A RID: 33626
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400835B RID: 33627
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400835C RID: 33628
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400835D RID: 33629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000887 RID: 2183
		public class SetEmotion : Console.ConsoleCommand
		{
			// Token: 0x0600C1FE RID: 49662 RVA: 0x002F5DB8 File Offset: 0x002F3FB8
			// Note: this type is marked as 'beforefieldinit'.
			static SetEmotion()
			{
				Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetEmotion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr);
				Console.SetEmotion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666461);
				Console.SetEmotion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666462);
				Console.SetEmotion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666463);
				Console.SetEmotion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666464);
				Console.SetEmotion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100666465);
			}

			// Token: 0x17003C87 RID: 15495
			// (get) Token: 0x0600C1FF RID: 49663 RVA: 0x002F5E48 File Offset: 0x002F4048
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102198, XrefRangeEnd = 102200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C88 RID: 15496
			// (get) Token: 0x0600C200 RID: 49664 RVA: 0x002F5E8C File Offset: 0x002F408C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102200, XrefRangeEnd = 102202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C89 RID: 15497
			// (get) Token: 0x0600C201 RID: 49665 RVA: 0x002F5ED0 File Offset: 0x002F40D0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102202, XrefRangeEnd = 102204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C202 RID: 49666 RVA: 0x002F5F14 File Offset: 0x002F4114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102204, XrefRangeEnd = 102235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C203 RID: 49667 RVA: 0x002F5F64 File Offset: 0x002F4164
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetEmotion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetEmotion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C204 RID: 49668 RVA: 0x0005E9D1 File Offset: 0x0005CBD1
			public SetEmotion(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400835E RID: 33630
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400835F RID: 33631
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008360 RID: 33632
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008361 RID: 33633
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008362 RID: 33634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000888 RID: 2184
		public class SetUnlocked : Console.ConsoleCommand
		{
			// Token: 0x0600C205 RID: 49669 RVA: 0x002F5FA0 File Offset: 0x002F41A0
			// Note: this type is marked as 'beforefieldinit'.
			static SetUnlocked()
			{
				Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetUnlocked");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr);
				Console.SetUnlocked.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666466);
				Console.SetUnlocked.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666467);
				Console.SetUnlocked.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666468);
				Console.SetUnlocked.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666469);
				Console.SetUnlocked.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100666470);
			}

			// Token: 0x17003C8A RID: 15498
			// (get) Token: 0x0600C206 RID: 49670 RVA: 0x002F6030 File Offset: 0x002F4230
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102235, XrefRangeEnd = 102237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C8B RID: 15499
			// (get) Token: 0x0600C207 RID: 49671 RVA: 0x002F6074 File Offset: 0x002F4274
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102237, XrefRangeEnd = 102239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C8C RID: 15500
			// (get) Token: 0x0600C208 RID: 49672 RVA: 0x002F60B8 File Offset: 0x002F42B8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102239, XrefRangeEnd = 102241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C209 RID: 49673 RVA: 0x002F60FC File Offset: 0x002F42FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102241, XrefRangeEnd = 102271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C20A RID: 49674 RVA: 0x002F614C File Offset: 0x002F434C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetUnlocked() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetUnlocked.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C20B RID: 49675 RVA: 0x0005E9DA File Offset: 0x0005CBDA
			public SetUnlocked(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008363 RID: 33635
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008364 RID: 33636
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008365 RID: 33637
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008366 RID: 33638
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008367 RID: 33639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000889 RID: 2185
		public class SetRelationship : Console.ConsoleCommand
		{
			// Token: 0x0600C20C RID: 49676 RVA: 0x002F6188 File Offset: 0x002F4388
			// Note: this type is marked as 'beforefieldinit'.
			static SetRelationship()
			{
				Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetRelationship");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr);
				Console.SetRelationship.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666471);
				Console.SetRelationship.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666472);
				Console.SetRelationship.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666473);
				Console.SetRelationship.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666474);
				Console.SetRelationship.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100666475);
			}

			// Token: 0x17003C8D RID: 15501
			// (get) Token: 0x0600C20D RID: 49677 RVA: 0x002F6218 File Offset: 0x002F4418
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102271, XrefRangeEnd = 102273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C8E RID: 15502
			// (get) Token: 0x0600C20E RID: 49678 RVA: 0x002F625C File Offset: 0x002F445C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102273, XrefRangeEnd = 102275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C8F RID: 15503
			// (get) Token: 0x0600C20F RID: 49679 RVA: 0x002F62A0 File Offset: 0x002F44A0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102275, XrefRangeEnd = 102277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C210 RID: 49680 RVA: 0x002F62E4 File Offset: 0x002F44E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102277, XrefRangeEnd = 102301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C211 RID: 49681 RVA: 0x002F6334 File Offset: 0x002F4534
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetRelationship() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetRelationship.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C212 RID: 49682 RVA: 0x0005E9E3 File Offset: 0x0005CBE3
			public SetRelationship(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008368 RID: 33640
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008369 RID: 33641
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400836A RID: 33642
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400836B RID: 33643
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400836C RID: 33644
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200088A RID: 2186
		public class AddEmployeeCommand : Console.ConsoleCommand
		{
			// Token: 0x0600C213 RID: 49683 RVA: 0x002F6370 File Offset: 0x002F4570
			// Note: this type is marked as 'beforefieldinit'.
			static AddEmployeeCommand()
			{
				Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "AddEmployeeCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666476);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666477);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666478);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666479);
				Console.AddEmployeeCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100666480);
			}

			// Token: 0x17003C90 RID: 15504
			// (get) Token: 0x0600C214 RID: 49684 RVA: 0x002F6400 File Offset: 0x002F4600
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102301, XrefRangeEnd = 102303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C91 RID: 15505
			// (get) Token: 0x0600C215 RID: 49685 RVA: 0x002F6444 File Offset: 0x002F4644
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102303, XrefRangeEnd = 102305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C92 RID: 15506
			// (get) Token: 0x0600C216 RID: 49686 RVA: 0x002F6488 File Offset: 0x002F4688
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102305, XrefRangeEnd = 102307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C217 RID: 49687 RVA: 0x002F64CC File Offset: 0x002F46CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102307, XrefRangeEnd = 102337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C218 RID: 49688 RVA: 0x002F651C File Offset: 0x002F471C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddEmployeeCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C219 RID: 49689 RVA: 0x0005E9EC File Offset: 0x0005CBEC
			public AddEmployeeCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400836D RID: 33645
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400836E RID: 33646
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400836F RID: 33647
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008370 RID: 33648
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008371 RID: 33649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C2D RID: 3117
			[ObfuscatedName("ScheduleOne.Console+AddEmployeeCommand+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E11B RID: 57627 RVA: 0x0034EBB4 File Offset: 0x0034CDB4
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr);
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, 100666481);
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, 100666482);
				}

				// Token: 0x0600E11C RID: 57628 RVA: 0x0034EC1C File Offset: 0x0034CE1C
				[CallerCount(2259)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E11D RID: 57629 RVA: 0x0034EC58 File Offset: 0x0034CE58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Property x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E11E RID: 57630 RVA: 0x0006DC25 File Offset: 0x0006BE25
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045BE RID: 17854
				// (get) Token: 0x0600E11F RID: 57631 RVA: 0x0034ECA8 File Offset: 0x0034CEA8
				// (set) Token: 0x0600E120 RID: 57632 RVA: 0x0006DC2E File Offset: 0x0006BE2E
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x040096BD RID: 38589
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x040096BE RID: 38590
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040096BF RID: 38591
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0;
			}
		}

		// Token: 0x0200088B RID: 2187
		public class SetDiscovered : Console.ConsoleCommand
		{
			// Token: 0x0600C21A RID: 49690 RVA: 0x002F6558 File Offset: 0x002F4758
			// Note: this type is marked as 'beforefieldinit'.
			static SetDiscovered()
			{
				Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetDiscovered");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr);
				Console.SetDiscovered.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666483);
				Console.SetDiscovered.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666484);
				Console.SetDiscovered.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666485);
				Console.SetDiscovered.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666486);
				Console.SetDiscovered.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100666487);
			}

			// Token: 0x17003C93 RID: 15507
			// (get) Token: 0x0600C21B RID: 49691 RVA: 0x002F65E8 File Offset: 0x002F47E8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102337, XrefRangeEnd = 102339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C94 RID: 15508
			// (get) Token: 0x0600C21C RID: 49692 RVA: 0x002F662C File Offset: 0x002F482C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102339, XrefRangeEnd = 102341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C95 RID: 15509
			// (get) Token: 0x0600C21D RID: 49693 RVA: 0x002F6670 File Offset: 0x002F4870
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102341, XrefRangeEnd = 102343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C21E RID: 49694 RVA: 0x002F66B4 File Offset: 0x002F48B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102343, XrefRangeEnd = 102389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C21F RID: 49695 RVA: 0x002F6704 File Offset: 0x002F4904
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetDiscovered() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetDiscovered.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C220 RID: 49696 RVA: 0x0005E9F5 File Offset: 0x0005CBF5
			public SetDiscovered(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008372 RID: 33650
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008373 RID: 33651
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008374 RID: 33652
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008375 RID: 33653
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008376 RID: 33654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200088C RID: 2188
		public class GrowPlants : Console.ConsoleCommand
		{
			// Token: 0x0600C221 RID: 49697 RVA: 0x002F6740 File Offset: 0x002F4940
			// Note: this type is marked as 'beforefieldinit'.
			static GrowPlants()
			{
				Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "GrowPlants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr);
				Console.GrowPlants.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666488);
				Console.GrowPlants.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666489);
				Console.GrowPlants.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666490);
				Console.GrowPlants.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666491);
				Console.GrowPlants.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100666492);
			}

			// Token: 0x17003C96 RID: 15510
			// (get) Token: 0x0600C222 RID: 49698 RVA: 0x002F67D0 File Offset: 0x002F49D0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102389, XrefRangeEnd = 102391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C97 RID: 15511
			// (get) Token: 0x0600C223 RID: 49699 RVA: 0x002F6814 File Offset: 0x002F4A14
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102391, XrefRangeEnd = 102393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C98 RID: 15512
			// (get) Token: 0x0600C224 RID: 49700 RVA: 0x002F6858 File Offset: 0x002F4A58
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102393, XrefRangeEnd = 102395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C225 RID: 49701 RVA: 0x002F689C File Offset: 0x002F4A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102395, XrefRangeEnd = 102403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C226 RID: 49702 RVA: 0x002F68EC File Offset: 0x002F4AEC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GrowPlants() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.GrowPlants.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C227 RID: 49703 RVA: 0x0005E9FE File Offset: 0x0005CBFE
			public GrowPlants(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008377 RID: 33655
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008378 RID: 33656
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008379 RID: 33657
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400837A RID: 33658
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400837B RID: 33659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200088D RID: 2189
		public class SetLawIntensity : Console.ConsoleCommand
		{
			// Token: 0x0600C228 RID: 49704 RVA: 0x002F6928 File Offset: 0x002F4B28
			// Note: this type is marked as 'beforefieldinit'.
			static SetLawIntensity()
			{
				Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetLawIntensity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666493);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666494);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666495);
				Console.SetLawIntensity.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666496);
				Console.SetLawIntensity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100666497);
			}

			// Token: 0x17003C99 RID: 15513
			// (get) Token: 0x0600C229 RID: 49705 RVA: 0x002F69B8 File Offset: 0x002F4BB8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102403, XrefRangeEnd = 102405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C9A RID: 15514
			// (get) Token: 0x0600C22A RID: 49706 RVA: 0x002F69FC File Offset: 0x002F4BFC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102405, XrefRangeEnd = 102407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C9B RID: 15515
			// (get) Token: 0x0600C22B RID: 49707 RVA: 0x002F6A40 File Offset: 0x002F4C40
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102407, XrefRangeEnd = 102409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C22C RID: 49708 RVA: 0x002F6A84 File Offset: 0x002F4C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102409, XrefRangeEnd = 102428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C22D RID: 49709 RVA: 0x002F6AD4 File Offset: 0x002F4CD4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetLawIntensity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetLawIntensity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C22E RID: 49710 RVA: 0x0005EA07 File Offset: 0x0005CC07
			public SetLawIntensity(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400837C RID: 33660
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400837D RID: 33661
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400837E RID: 33662
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400837F RID: 33663
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008380 RID: 33664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200088E RID: 2190
		public class SetQuality : Console.ConsoleCommand
		{
			// Token: 0x0600C22F RID: 49711 RVA: 0x002F6B10 File Offset: 0x002F4D10
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuality()
			{
				Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuality");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr);
				Console.SetQuality.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666498);
				Console.SetQuality.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666499);
				Console.SetQuality.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666500);
				Console.SetQuality.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666501);
				Console.SetQuality.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100666502);
			}

			// Token: 0x17003C9C RID: 15516
			// (get) Token: 0x0600C230 RID: 49712 RVA: 0x002F6BA0 File Offset: 0x002F4DA0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102428, XrefRangeEnd = 102430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C9D RID: 15517
			// (get) Token: 0x0600C231 RID: 49713 RVA: 0x002F6BE4 File Offset: 0x002F4DE4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102430, XrefRangeEnd = 102432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003C9E RID: 15518
			// (get) Token: 0x0600C232 RID: 49714 RVA: 0x002F6C28 File Offset: 0x002F4E28
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102432, XrefRangeEnd = 102434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C233 RID: 49715 RVA: 0x002F6C6C File Offset: 0x002F4E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102434, XrefRangeEnd = 102453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C234 RID: 49716 RVA: 0x002F6CBC File Offset: 0x002F4EBC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuality() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuality.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C235 RID: 49717 RVA: 0x0005EA10 File Offset: 0x0005CC10
			public SetQuality(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008381 RID: 33665
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008382 RID: 33666
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008383 RID: 33667
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008384 RID: 33668
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008385 RID: 33669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200088F RID: 2191
		public class Bind : Console.ConsoleCommand
		{
			// Token: 0x0600C236 RID: 49718 RVA: 0x002F6CF8 File Offset: 0x002F4EF8
			// Note: this type is marked as 'beforefieldinit'.
			static Bind()
			{
				Il2CppClassPointerStore<Console.Bind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Bind");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr);
				Console.Bind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666503);
				Console.Bind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666504);
				Console.Bind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666505);
				Console.Bind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666506);
				Console.Bind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100666507);
			}

			// Token: 0x17003C9F RID: 15519
			// (get) Token: 0x0600C237 RID: 49719 RVA: 0x002F6D88 File Offset: 0x002F4F88
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102453, XrefRangeEnd = 102455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA0 RID: 15520
			// (get) Token: 0x0600C238 RID: 49720 RVA: 0x002F6DCC File Offset: 0x002F4FCC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102455, XrefRangeEnd = 102457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA1 RID: 15521
			// (get) Token: 0x0600C239 RID: 49721 RVA: 0x002F6E10 File Offset: 0x002F5010
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102457, XrefRangeEnd = 102459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C23A RID: 49722 RVA: 0x002F6E54 File Offset: 0x002F5054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102459, XrefRangeEnd = 102476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C23B RID: 49723 RVA: 0x002F6EA4 File Offset: 0x002F50A4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Bind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Bind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C23C RID: 49724 RVA: 0x0005EA19 File Offset: 0x0005CC19
			public Bind(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008386 RID: 33670
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008387 RID: 33671
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008388 RID: 33672
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008389 RID: 33673
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400838A RID: 33674
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000890 RID: 2192
		public class Unbind : Console.ConsoleCommand
		{
			// Token: 0x0600C23D RID: 49725 RVA: 0x002F6EE0 File Offset: 0x002F50E0
			// Note: this type is marked as 'beforefieldinit'.
			static Unbind()
			{
				Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Unbind");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr);
				Console.Unbind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666508);
				Console.Unbind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666509);
				Console.Unbind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666510);
				Console.Unbind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666511);
				Console.Unbind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100666512);
			}

			// Token: 0x17003CA2 RID: 15522
			// (get) Token: 0x0600C23E RID: 49726 RVA: 0x002F6F70 File Offset: 0x002F5170
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102476, XrefRangeEnd = 102478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA3 RID: 15523
			// (get) Token: 0x0600C23F RID: 49727 RVA: 0x002F6FB4 File Offset: 0x002F51B4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102478, XrefRangeEnd = 102480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA4 RID: 15524
			// (get) Token: 0x0600C240 RID: 49728 RVA: 0x002F6FF8 File Offset: 0x002F51F8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102480, XrefRangeEnd = 102482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C241 RID: 49729 RVA: 0x002F703C File Offset: 0x002F523C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102482, XrefRangeEnd = 102497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C242 RID: 49730 RVA: 0x002F708C File Offset: 0x002F528C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Unbind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Unbind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C243 RID: 49731 RVA: 0x0005EA22 File Offset: 0x0005CC22
			public Unbind(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400838B RID: 33675
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400838C RID: 33676
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400838D RID: 33677
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400838E RID: 33678
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400838F RID: 33679
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000891 RID: 2193
		public class ClearBinds : Console.ConsoleCommand
		{
			// Token: 0x0600C244 RID: 49732 RVA: 0x002F70C8 File Offset: 0x002F52C8
			// Note: this type is marked as 'beforefieldinit'.
			static ClearBinds()
			{
				Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearBinds");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr);
				Console.ClearBinds.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666513);
				Console.ClearBinds.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666514);
				Console.ClearBinds.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666515);
				Console.ClearBinds.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666516);
				Console.ClearBinds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100666517);
			}

			// Token: 0x17003CA5 RID: 15525
			// (get) Token: 0x0600C245 RID: 49733 RVA: 0x002F7158 File Offset: 0x002F5358
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102497, XrefRangeEnd = 102499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA6 RID: 15526
			// (get) Token: 0x0600C246 RID: 49734 RVA: 0x002F719C File Offset: 0x002F539C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102499, XrefRangeEnd = 102501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA7 RID: 15527
			// (get) Token: 0x0600C247 RID: 49735 RVA: 0x002F71E0 File Offset: 0x002F53E0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102501, XrefRangeEnd = 102503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C248 RID: 49736 RVA: 0x002F7224 File Offset: 0x002F5424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102503, XrefRangeEnd = 102520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C249 RID: 49737 RVA: 0x002F7274 File Offset: 0x002F5474
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearBinds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearBinds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C24A RID: 49738 RVA: 0x0005EA2B File Offset: 0x0005CC2B
			public ClearBinds(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008390 RID: 33680
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008391 RID: 33681
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008392 RID: 33682
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008393 RID: 33683
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008394 RID: 33684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000892 RID: 2194
		public class HideUI : Console.ConsoleCommand
		{
			// Token: 0x0600C24B RID: 49739 RVA: 0x002F72B0 File Offset: 0x002F54B0
			// Note: this type is marked as 'beforefieldinit'.
			static HideUI()
			{
				Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "HideUI");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr);
				Console.HideUI.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666518);
				Console.HideUI.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666519);
				Console.HideUI.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666520);
				Console.HideUI.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666521);
				Console.HideUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100666522);
			}

			// Token: 0x17003CA8 RID: 15528
			// (get) Token: 0x0600C24C RID: 49740 RVA: 0x002F7340 File Offset: 0x002F5540
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102520, XrefRangeEnd = 102522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CA9 RID: 15529
			// (get) Token: 0x0600C24D RID: 49741 RVA: 0x002F7384 File Offset: 0x002F5584
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102522, XrefRangeEnd = 102524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CAA RID: 15530
			// (get) Token: 0x0600C24E RID: 49742 RVA: 0x002F73C8 File Offset: 0x002F55C8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102524, XrefRangeEnd = 102526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C24F RID: 49743 RVA: 0x002F740C File Offset: 0x002F560C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102526, XrefRangeEnd = 102532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C250 RID: 49744 RVA: 0x002F745C File Offset: 0x002F565C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HideUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.HideUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C251 RID: 49745 RVA: 0x0005EA34 File Offset: 0x0005CC34
			public HideUI(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008395 RID: 33685
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04008396 RID: 33686
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04008397 RID: 33687
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04008398 RID: 33688
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04008399 RID: 33689
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000893 RID: 2195
		public class GiveXP : Console.ConsoleCommand
		{
			// Token: 0x0600C252 RID: 49746 RVA: 0x002F7498 File Offset: 0x002F5698
			// Note: this type is marked as 'beforefieldinit'.
			static GiveXP()
			{
				Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "GiveXP");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr);
				Console.GiveXP.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666523);
				Console.GiveXP.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666524);
				Console.GiveXP.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666525);
				Console.GiveXP.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666526);
				Console.GiveXP.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100666527);
			}

			// Token: 0x17003CAB RID: 15531
			// (get) Token: 0x0600C253 RID: 49747 RVA: 0x002F7528 File Offset: 0x002F5728
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102532, XrefRangeEnd = 102534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CAC RID: 15532
			// (get) Token: 0x0600C254 RID: 49748 RVA: 0x002F756C File Offset: 0x002F576C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102534, XrefRangeEnd = 102536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CAD RID: 15533
			// (get) Token: 0x0600C255 RID: 49749 RVA: 0x002F75B0 File Offset: 0x002F57B0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102536, XrefRangeEnd = 102538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C256 RID: 49750 RVA: 0x002F75F4 File Offset: 0x002F57F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102538, XrefRangeEnd = 102559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C257 RID: 49751 RVA: 0x002F7644 File Offset: 0x002F5844
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GiveXP() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.GiveXP.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C258 RID: 49752 RVA: 0x0005EA3D File Offset: 0x0005CC3D
			public GiveXP(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400839A RID: 33690
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400839B RID: 33691
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400839C RID: 33692
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400839D RID: 33693
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400839E RID: 33694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000894 RID: 2196
		public class Disable : Console.ConsoleCommand
		{
			// Token: 0x0600C259 RID: 49753 RVA: 0x002F7680 File Offset: 0x002F5880
			// Note: this type is marked as 'beforefieldinit'.
			static Disable()
			{
				Il2CppClassPointerStore<Console.Disable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Disable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr);
				Console.Disable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666528);
				Console.Disable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666529);
				Console.Disable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666530);
				Console.Disable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666531);
				Console.Disable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100666532);
			}

			// Token: 0x17003CAE RID: 15534
			// (get) Token: 0x0600C25A RID: 49754 RVA: 0x002F7710 File Offset: 0x002F5910
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102562, XrefRangeEnd = 102564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CAF RID: 15535
			// (get) Token: 0x0600C25B RID: 49755 RVA: 0x002F7754 File Offset: 0x002F5954
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102564, XrefRangeEnd = 102566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB0 RID: 15536
			// (get) Token: 0x0600C25C RID: 49756 RVA: 0x002F7798 File Offset: 0x002F5998
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102566, XrefRangeEnd = 102568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C25D RID: 49757 RVA: 0x002F77DC File Offset: 0x002F59DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102568, XrefRangeEnd = 102610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C25E RID: 49758 RVA: 0x002F782C File Offset: 0x002F5A2C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Disable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C25F RID: 49759 RVA: 0x0005EA46 File Offset: 0x0005CC46
			public Disable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400839F RID: 33695
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083A0 RID: 33696
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083A1 RID: 33697
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083A2 RID: 33698
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083A3 RID: 33699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C2E RID: 3118
			[ObfuscatedName("ScheduleOne.Console+Disable+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E121 RID: 57633 RVA: 0x0034ECD0 File Offset: 0x0034CED0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr);
					Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, 100666533);
					Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, 100666534);
				}

				// Token: 0x0600E122 RID: 57634 RVA: 0x0034ED38 File Offset: 0x0034CF38
				[CallerCount(2259)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E123 RID: 57635 RVA: 0x0034ED74 File Offset: 0x0034CF74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102559, XrefRangeEnd = 102562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Console.LabelledGameObject x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E124 RID: 57636 RVA: 0x0006DC4D File Offset: 0x0006BE4D
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045BF RID: 17855
				// (get) Token: 0x0600E125 RID: 57637 RVA: 0x0034EDC4 File Offset: 0x0034CFC4
				// (set) Token: 0x0600E126 RID: 57638 RVA: 0x0006DC56 File Offset: 0x0006BE56
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x040096C0 RID: 38592
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x040096C1 RID: 38593
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040096C2 RID: 38594
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0;
			}
		}

		// Token: 0x02000895 RID: 2197
		public class Enable : Console.ConsoleCommand
		{
			// Token: 0x0600C260 RID: 49760 RVA: 0x002F7868 File Offset: 0x002F5A68
			// Note: this type is marked as 'beforefieldinit'.
			static Enable()
			{
				Il2CppClassPointerStore<Console.Enable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Enable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr);
				Console.Enable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666535);
				Console.Enable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666536);
				Console.Enable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666537);
				Console.Enable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666538);
				Console.Enable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100666539);
			}

			// Token: 0x17003CB1 RID: 15537
			// (get) Token: 0x0600C261 RID: 49761 RVA: 0x002F78F8 File Offset: 0x002F5AF8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102610, XrefRangeEnd = 102612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB2 RID: 15538
			// (get) Token: 0x0600C262 RID: 49762 RVA: 0x002F793C File Offset: 0x002F5B3C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102612, XrefRangeEnd = 102614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB3 RID: 15539
			// (get) Token: 0x0600C263 RID: 49763 RVA: 0x002F7980 File Offset: 0x002F5B80
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102614, XrefRangeEnd = 102616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C264 RID: 49764 RVA: 0x002F79C4 File Offset: 0x002F5BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102616, XrefRangeEnd = 102658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C265 RID: 49765 RVA: 0x002F7A14 File Offset: 0x002F5C14
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C266 RID: 49766 RVA: 0x0005EA4F File Offset: 0x0005CC4F
			public Enable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083A4 RID: 33700
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083A5 RID: 33701
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083A6 RID: 33702
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083A7 RID: 33703
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083A8 RID: 33704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C2F RID: 3119
			[ObfuscatedName("ScheduleOne.Console+Enable+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600E127 RID: 57639 RVA: 0x0034EDEC File Offset: 0x0034CFEC
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr);
					Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, 100666540);
					Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, 100666541);
				}

				// Token: 0x0600E128 RID: 57640 RVA: 0x0034EE54 File Offset: 0x0034D054
				[CallerCount(2259)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E129 RID: 57641 RVA: 0x0034EE90 File Offset: 0x0034D090
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Console.LabelledGameObject x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E12A RID: 57642 RVA: 0x0006DC75 File Offset: 0x0006BE75
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045C0 RID: 17856
				// (get) Token: 0x0600E12B RID: 57643 RVA: 0x0034EEE0 File Offset: 0x0034D0E0
				// (set) Token: 0x0600E12C RID: 57644 RVA: 0x0006DC7E File Offset: 0x0006BE7E
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x040096C3 RID: 38595
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x040096C4 RID: 38596
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040096C5 RID: 38597
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0;
			}
		}

		// Token: 0x02000896 RID: 2198
		public class EndTutorial : Console.ConsoleCommand
		{
			// Token: 0x0600C267 RID: 49767 RVA: 0x002F7A50 File Offset: 0x002F5C50
			// Note: this type is marked as 'beforefieldinit'.
			static EndTutorial()
			{
				Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "EndTutorial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr);
				Console.EndTutorial.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666542);
				Console.EndTutorial.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666543);
				Console.EndTutorial.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666544);
				Console.EndTutorial.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666545);
				Console.EndTutorial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100666546);
			}

			// Token: 0x17003CB4 RID: 15540
			// (get) Token: 0x0600C268 RID: 49768 RVA: 0x002F7AE0 File Offset: 0x002F5CE0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102658, XrefRangeEnd = 102660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB5 RID: 15541
			// (get) Token: 0x0600C269 RID: 49769 RVA: 0x002F7B24 File Offset: 0x002F5D24
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102660, XrefRangeEnd = 102662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB6 RID: 15542
			// (get) Token: 0x0600C26A RID: 49770 RVA: 0x002F7B68 File Offset: 0x002F5D68
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102662, XrefRangeEnd = 102664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C26B RID: 49771 RVA: 0x002F7BAC File Offset: 0x002F5DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102664, XrefRangeEnd = 102670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C26C RID: 49772 RVA: 0x002F7BFC File Offset: 0x002F5DFC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EndTutorial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.EndTutorial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C26D RID: 49773 RVA: 0x0005EA58 File Offset: 0x0005CC58
			public EndTutorial(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083A9 RID: 33705
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083AA RID: 33706
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083AB RID: 33707
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083AC RID: 33708
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083AD RID: 33709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000897 RID: 2199
		public class DisableNPCAsset : Console.ConsoleCommand
		{
			// Token: 0x0600C26E RID: 49774 RVA: 0x002F7C38 File Offset: 0x002F5E38
			// Note: this type is marked as 'beforefieldinit'.
			static DisableNPCAsset()
			{
				Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DisableNPCAsset");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666547);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666548);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666549);
				Console.DisableNPCAsset.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666550);
				Console.DisableNPCAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100666551);
			}

			// Token: 0x17003CB7 RID: 15543
			// (get) Token: 0x0600C26F RID: 49775 RVA: 0x002F7CC8 File Offset: 0x002F5EC8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102670, XrefRangeEnd = 102672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB8 RID: 15544
			// (get) Token: 0x0600C270 RID: 49776 RVA: 0x002F7D0C File Offset: 0x002F5F0C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102672, XrefRangeEnd = 102674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CB9 RID: 15545
			// (get) Token: 0x0600C271 RID: 49777 RVA: 0x002F7D50 File Offset: 0x002F5F50
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102674, XrefRangeEnd = 102676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C272 RID: 49778 RVA: 0x002F7D94 File Offset: 0x002F5F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102676, XrefRangeEnd = 102719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C273 RID: 49779 RVA: 0x002F7DE4 File Offset: 0x002F5FE4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisableNPCAsset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DisableNPCAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C274 RID: 49780 RVA: 0x0005EA61 File Offset: 0x0005CC61
			public DisableNPCAsset(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083AE RID: 33710
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083AF RID: 33711
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083B0 RID: 33712
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083B1 RID: 33713
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083B2 RID: 33714
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000898 RID: 2200
		public class ShowFPS : Console.ConsoleCommand
		{
			// Token: 0x0600C275 RID: 49781 RVA: 0x002F7E20 File Offset: 0x002F6020
			// Note: this type is marked as 'beforefieldinit'.
			static ShowFPS()
			{
				Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ShowFPS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr);
				Console.ShowFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666552);
				Console.ShowFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666553);
				Console.ShowFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666554);
				Console.ShowFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666555);
				Console.ShowFPS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100666556);
			}

			// Token: 0x17003CBA RID: 15546
			// (get) Token: 0x0600C276 RID: 49782 RVA: 0x002F7EB0 File Offset: 0x002F60B0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102719, XrefRangeEnd = 102721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CBB RID: 15547
			// (get) Token: 0x0600C277 RID: 49783 RVA: 0x002F7EF4 File Offset: 0x002F60F4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102721, XrefRangeEnd = 102723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CBC RID: 15548
			// (get) Token: 0x0600C278 RID: 49784 RVA: 0x002F7F38 File Offset: 0x002F6138
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102723, XrefRangeEnd = 102725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C279 RID: 49785 RVA: 0x002F7F7C File Offset: 0x002F617C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102725, XrefRangeEnd = 102732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C27A RID: 49786 RVA: 0x002F7FCC File Offset: 0x002F61CC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShowFPS() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ShowFPS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C27B RID: 49787 RVA: 0x0005EA6A File Offset: 0x0005CC6A
			public ShowFPS(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083B3 RID: 33715
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083B4 RID: 33716
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083B5 RID: 33717
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083B6 RID: 33718
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083B7 RID: 33719
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000899 RID: 2201
		public class HideFPS : Console.ConsoleCommand
		{
			// Token: 0x0600C27C RID: 49788 RVA: 0x002F8008 File Offset: 0x002F6208
			// Note: this type is marked as 'beforefieldinit'.
			static HideFPS()
			{
				Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "HideFPS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr);
				Console.HideFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666557);
				Console.HideFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666558);
				Console.HideFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666559);
				Console.HideFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666560);
				Console.HideFPS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100666561);
			}

			// Token: 0x17003CBD RID: 15549
			// (get) Token: 0x0600C27D RID: 49789 RVA: 0x002F8098 File Offset: 0x002F6298
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102732, XrefRangeEnd = 102734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CBE RID: 15550
			// (get) Token: 0x0600C27E RID: 49790 RVA: 0x002F80DC File Offset: 0x002F62DC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102734, XrefRangeEnd = 102736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CBF RID: 15551
			// (get) Token: 0x0600C27F RID: 49791 RVA: 0x002F8120 File Offset: 0x002F6320
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102736, XrefRangeEnd = 102738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C280 RID: 49792 RVA: 0x002F8164 File Offset: 0x002F6364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102738, XrefRangeEnd = 102745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C281 RID: 49793 RVA: 0x002F81B4 File Offset: 0x002F63B4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HideFPS() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.HideFPS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C282 RID: 49794 RVA: 0x0005EA73 File Offset: 0x0005CC73
			public HideFPS(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083B8 RID: 33720
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083B9 RID: 33721
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083BA RID: 33722
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083BB RID: 33723
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083BC RID: 33724
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200089A RID: 2202
		public class ClearTrash : Console.ConsoleCommand
		{
			// Token: 0x0600C283 RID: 49795 RVA: 0x002F81F0 File Offset: 0x002F63F0
			// Note: this type is marked as 'beforefieldinit'.
			static ClearTrash()
			{
				Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearTrash");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr);
				Console.ClearTrash.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666562);
				Console.ClearTrash.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666563);
				Console.ClearTrash.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666564);
				Console.ClearTrash.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666565);
				Console.ClearTrash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100666566);
			}

			// Token: 0x17003CC0 RID: 15552
			// (get) Token: 0x0600C284 RID: 49796 RVA: 0x002F8280 File Offset: 0x002F6480
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102745, XrefRangeEnd = 102747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CC1 RID: 15553
			// (get) Token: 0x0600C285 RID: 49797 RVA: 0x002F82C4 File Offset: 0x002F64C4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102747, XrefRangeEnd = 102749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003CC2 RID: 15554
			// (get) Token: 0x0600C286 RID: 49798 RVA: 0x002F8308 File Offset: 0x002F6508
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102749, XrefRangeEnd = 102751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600C287 RID: 49799 RVA: 0x002F834C File Offset: 0x002F654C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102751, XrefRangeEnd = 102757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C288 RID: 49800 RVA: 0x002F839C File Offset: 0x002F659C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearTrash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearTrash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C289 RID: 49801 RVA: 0x0005EA7C File Offset: 0x0005CC7C
			public ClearTrash(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040083BD RID: 33725
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040083BE RID: 33726
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040083BF RID: 33727
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040083C0 RID: 33728
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040083C1 RID: 33729
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200089B RID: 2203
		[Serializable]
		public class LabelledGameObject : Il2CppSystem.Object
		{
			// Token: 0x0600C28A RID: 49802 RVA: 0x002F83D8 File Offset: 0x002F65D8
			// Note: this type is marked as 'beforefieldinit'.
			static LabelledGameObject()
			{
				Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "LabelledGameObject");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr);
				Console.LabelledGameObject.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, "Label");
				Console.LabelledGameObject.NativeFieldInfoPtr_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, "GameObject");
				Console.LabelledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, 100666567);
			}

			// Token: 0x0600C28B RID: 49803 RVA: 0x002F8440 File Offset: 0x002F6640
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LabelledGameObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.LabelledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C28C RID: 49804 RVA: 0x0005EA85 File Offset: 0x0005CC85
			public LabelledGameObject(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CC3 RID: 15555
			// (get) Token: 0x0600C28D RID: 49805 RVA: 0x002F847C File Offset: 0x002F667C
			// (set) Token: 0x0600C28E RID: 49806 RVA: 0x0005EA8E File Offset: 0x0005CC8E
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003CC4 RID: 15556
			// (get) Token: 0x0600C28F RID: 49807 RVA: 0x002F84A4 File Offset: 0x002F66A4
			// (set) Token: 0x0600C290 RID: 49808 RVA: 0x0005EAAD File Offset: 0x0005CCAD
			public unsafe GameObject GameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_GameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_GameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083C2 RID: 33730
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x040083C3 RID: 33731
			private static readonly IntPtr NativeFieldInfoPtr_GameObject;

			// Token: 0x040083C4 RID: 33732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
