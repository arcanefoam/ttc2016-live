/*
 * generated by Xtext 2.9.2
 */
package eu.ttc.dataflow.parser.antlr;

import com.google.inject.Inject;
import eu.ttc.dataflow.parser.antlr.internal.InternalDataflowDSLParser;
import eu.ttc.dataflow.services.DataflowDSLGrammarAccess;
import org.eclipse.xtext.parser.antlr.AbstractAntlrParser;
import org.eclipse.xtext.parser.antlr.XtextTokenStream;

public class DataflowDSLParser extends AbstractAntlrParser {

	@Inject
	private DataflowDSLGrammarAccess grammarAccess;

	@Override
	protected void setInitialHiddenTokens(XtextTokenStream tokenStream) {
		tokenStream.setInitialHiddenTokens("RULE_WS", "RULE_ML_COMMENT", "RULE_SL_COMMENT");
	}
	

	@Override
	protected InternalDataflowDSLParser createParser(XtextTokenStream stream) {
		return new InternalDataflowDSLParser(stream, getGrammarAccess());
	}

	@Override 
	protected String getDefaultRuleName() {
		return "Model";
	}

	public DataflowDSLGrammarAccess getGrammarAccess() {
		return this.grammarAccess;
	}

	public void setGrammarAccess(DataflowDSLGrammarAccess grammarAccess) {
		this.grammarAccess = grammarAccess;
	}
}